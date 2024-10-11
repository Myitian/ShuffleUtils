using Myitian.Shuffling;
using System.Buffers;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace FileShuffle;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        X_Changed(null, null);
    }

    private readonly OpenFileDialog OFD = new();
    private readonly SaveFileDialog SFD = new();
    private readonly XShuffle Shuffler = new();

    private Mode CurrentMode;
    private bool Preview;
    private bool Changed;
    private byte[]? BinaryBuffer;
    private char[]? CharBuffer;

    private bool CheckIfLoaded()
    {
        switch (CurrentMode)
        {
            case Mode.Binary:
                if (BinaryBuffer is null)
                    return false;
                break;
            default:
                if (Preview && Changed)
                    CharBuffer = TB_Preview.Text.ToCharArray();
                else if (CharBuffer is null)
                    return false;
                break;
        }
        return true;
    }

    private void Shuffle()
    {
        switch (CurrentMode)
        {
            case Mode.Binary:
                if (BinaryBuffer is null)
                    return;
                Shuffler.Shuffle(BinaryBuffer);
                break;
            case Mode.Text:
                if (CharBuffer is null)
                    return;
                Shuffler.Shuffle(CharBuffer);
                break;
            default:
                if (CharBuffer is null)
                    return;
                char[] buffer = ArrayPool<char>.Shared.Rent(CharBuffer.Length);
                CharBuffer.CopyTo(buffer, 0);
                Span<int> elements = CollectionsMarshal.AsSpan(LoadTextElements(CharBuffer));
                Shuffler.Shuffle(elements);
                CreateString(elements, buffer.AsSpan(0, CharBuffer.Length), CharBuffer);
                break;
        }
    }

    private void ReverseShuffle()
    {
        switch (CurrentMode)
        {
            case Mode.Binary:
                if (BinaryBuffer is null)
                    return;
                Shuffler.ReversedShuffle(BinaryBuffer);
                break;
            case Mode.Text:
                if (CharBuffer is null)
                    return;
                Shuffler.ReversedShuffle(CharBuffer);
                break;
            default:
                if (CharBuffer is null)
                    return;
                char[] buffer = ArrayPool<char>.Shared.Rent(CharBuffer.Length);
                CharBuffer.CopyTo(buffer, 0);
                Span<int> elements = CollectionsMarshal.AsSpan(LoadTextElements(CharBuffer));
                Shuffler.ReversedShuffle(elements);
                CreateString(elements, buffer.AsSpan(0, CharBuffer.Length), CharBuffer);
                break;
        }
    }

    private void PostShuffle()
    {
        switch (CurrentMode)
        {
            case Mode.Binary:
                TB_Preview.Text = $"[{DateTime.Now:O}] 已执行！";
                break;
            default:
                if (Preview)
                    TB_Preview.Text = new(CharBuffer);
                else
                    TB_Preview.Text = $"[{DateTime.Now:O}] 已执行！";
                Changed = false;
                break;
        }
    }

    private static List<int> LoadTextElements(ReadOnlySpan<char> text)
    {
        List<int> elements = [];
        int offset = 0;
        while (text.Length > 0)
        {
            int len = StringInfo.GetNextTextElementLength(text);
            elements.Add(offset);
            offset += len;
            text = text[len..];
        }
        return elements;
    }

    private static void CreateString(ReadOnlySpan<int> elements, ReadOnlySpan<char> s, Span<char> buffer)
    {
        for (int i = 0, offs = 0; i < elements.Length; i++)
        {
            ReadOnlySpan<char> slice = s[elements[i]..];
            int len = StringInfo.GetNextTextElementLength(slice);
            slice[..len].CopyTo(buffer[offs..]);
            offs += len;
        }
    }

    private Encoding? GetEncoding()
    {
        try
        {
            return Encoding.GetEncoding(CB_Encoding.Text);
        }
        catch { }
        try
        {
            return CodePagesEncodingProvider.Instance.GetEncoding(CB_Encoding.Text);
        }
        catch { }
        if (int.TryParse(CB_Encoding.Text, out int cp))
        {
            try
            {
                return Encoding.GetEncoding(cp);
            }
            catch { }
            try
            {
                return CodePagesEncodingProvider.Instance.GetEncoding(cp);
            }
            catch { }
        }
        return null;
    }

    private void MainForm_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
        {
            if (files.Length > 0)
                TB_FileName.Text = files[0];
        }
        else if (e.Data?.GetData(DataFormats.UnicodeText) is string utext)
        {
            TB_FileName.Text = utext;
        }
        else if (e.Data?.GetData(DataFormats.OemText) is string otext)
        {
            TB_FileName.Text = otext;
        }
        else if (e.Data?.GetData(DataFormats.Text) is string text)
        {
            TB_FileName.Text = text;
        }
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data is not null && (
            e.Data.GetDataPresent(DataFormats.FileDrop) ||
            e.Data.GetDataPresent(DataFormats.UnicodeText) ||
            e.Data.GetDataPresent(DataFormats.OemText) ||
            e.Data.GetDataPresent(DataFormats.Text)))
            e.Effect = DragDropEffects.Copy;
    }

    private void B_Browse_Click(object sender, EventArgs e)
    {
        if (OFD.ShowDialog() == DialogResult.OK)
            TB_FileName.Text = OFD.FileName;
    }

    private void B_Load_Click(object sender, EventArgs e)
    {
        if (!File.Exists(TB_FileName.Text))
        {
            MessageBox.Show("文件不存在！");
            return;
        }
        Encoding? encoding = GetEncoding();
        if (CurrentMode != Mode.Binary && encoding is null)
        {
            MessageBox.Show("请输入有效的编码名称！");
            return;
        }
        string file = TB_FileName.Text;
        switch (CurrentMode)
        {
            case Mode.Binary:
                BinaryBuffer = File.ReadAllBytes(file);
                CharBuffer = null;
                TB_Preview.Text = $"[{DateTime.Now:O}] 已加载文件！";
                break;
            default:
                string str = File.ReadAllText(file, encoding!);
                CharBuffer = str.ToCharArray();
                BinaryBuffer = null;
                if (Preview)
                    TB_Preview.Text = str;
                else
                    TB_Preview.Text = $"[{DateTime.Now:O}] 已加载文件！";
                Changed = false;
                break;
        }
    }

    private void X_Changed(object? sender, EventArgs? e)
    {
        if (RB_BinaryMode.Checked)
            CurrentMode = Mode.Binary;
        else if (RB_TextMode.Checked)
            CurrentMode = Mode.Text;
        else
            CurrentMode = Mode.TextElement;
        Preview = CB_Preview.Checked;
        switch (CurrentMode)
        {
            case Mode.Binary:
                CB_Preview.Enabled = false;
                L_Encoding.Enabled = false;
                CB_Encoding.Enabled = false;
                break;
            default:
                CB_Preview.Enabled = true;
                L_Encoding.Enabled = true;
                CB_Encoding.Enabled = true;
                break;
        }
        TB_Preview.Enabled = CB_Preview.Enabled && CB_Preview.Checked;
        if (!TB_Preview.Enabled)
            TB_Preview.Clear();
    }

    private void B_Reset_Click(object sender, EventArgs e)
    {
        NUD_Seed.Value = XShuffle.DeafultSeed;
        NUD_X.Value = XShuffle.DeafultXorshiftX;
        NUD_Y.Value = XShuffle.DeafultXorshiftY;
        NUD_Z.Value = XShuffle.DeafultXorshiftZ;
        NUD_Multiplier.Value = XShuffle.DeafultXorshiftStarMultiplier;
    }

    private async void B_Shuffle_Click(object sender, EventArgs e)
    {
        if (!CheckIfLoaded())
        {
            MessageBox.Show("请先加载文件！");
            return;
        }
        Shuffler.Seed = (uint)NUD_Seed.Value;
        Shuffler.XorshiftX = (int)NUD_X.Value;
        Shuffler.XorshiftY = (int)NUD_Y.Value;
        Shuffler.XorshiftZ = (int)NUD_Z.Value;
        Shuffler.XorshiftStarMultiplier = (ulong)NUD_Multiplier.Value;
        await Task.Run(Shuffle);
        PostShuffle();
    }

    private async void B_ReverseShuffle_Click(object sender, EventArgs e)
    {
        if (!CheckIfLoaded())
        {
            MessageBox.Show("请先加载文件！");
            return;
        }
        Shuffler.Seed = (uint)NUD_Seed.Value;
        Shuffler.XorshiftX = (int)NUD_X.Value;
        Shuffler.XorshiftY = (int)NUD_Y.Value;
        Shuffler.XorshiftZ = (int)NUD_Z.Value;
        Shuffler.XorshiftStarMultiplier = (ulong)NUD_Multiplier.Value;
        await Task.Run(ReverseShuffle);
        PostShuffle();
    }

    private async void B_Save_Click(object sender, EventArgs e)
    {
        if (!CheckIfLoaded())
        {
            MessageBox.Show("请先加载文件！");
            return;
        }
        Encoding? encoding = GetEncoding();
        if (CurrentMode != Mode.Binary && encoding is null)
        {
            MessageBox.Show("请输入有效的编码名称！");
            return;
        }
        if (SFD.ShowDialog() == DialogResult.OK)
        {
            string file = SFD.FileName;
            try
            {
                await Task.Run(() =>
                {
                    switch (CurrentMode)
                    {
                        case Mode.Binary:
                            File.WriteAllBytes(file, BinaryBuffer ?? []);
                            break;
                        default:
                            using (StreamWriter sw = new(file, false, encoding!))
                                sw.Write(CharBuffer);
                            break;
                    }
                });
            }
            catch (Exception ex)
            {
                StringBuilder sb = new(ex.Message);
                while (ex.InnerException is not null)
                {
                    ex = ex.InnerException;
                    sb.AppendLine().Append(ex.Message);
                }
                MessageBox.Show(sb.ToString(), "错误");
            }
        }
    }

    private void TB_Preview_TextChanged(object sender, EventArgs e)
    {
        if (TB_Preview.Enabled)
            Changed = true;
    }
}

public enum Mode
{
    Binary,
    Text,
    TextElement
}