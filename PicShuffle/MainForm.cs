using Myitian.Drawing;
using Myitian.Shuffling;
using System.Drawing.Imaging;
using System.Text;

namespace PicShuffle;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private readonly OpenFileDialog OFD = new()
    {
        Filter = "图片文件|*.png;*.jpeg;*.jpg;*.jpe;*.jfif;*.gif;*.bmp;*.tiff;*.tif;*.ico|PNG 文件|*.png|JPEG 文件|*.jpeg;*.jpg;*.jpe;*.jfif|GIF 文件|*.gif|BMP 文件|*.bmp|TIFF 文件|*.tiff;*.tif|所有文件|*.*"
    };
    private readonly SaveFileDialog SFD = new()
    {
        Filter = "PNG 文件|*.png|BMP 文件|*.bmp|TIFF 文件|*.tif;*.tiff"
    };
    private readonly XShuffle Shuffler = new();
    private DirectBitmap? BMP = null;

    private void LoadImage(string file)
    {
        using Bitmap bmp = new(file);
        BMP?.Dispose();
        BMP = new(bmp);
    }

    private void Shuffle()
    {
        if (!BMP.HasValue)
            return;
        Shuffler.Shuffle(BMP.Value.Bits);
    }

    private void ReverseShuffle()
    {
        if (!BMP.HasValue)
            return;
        Shuffler.ReversedShuffle(BMP.Value.Bits);
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

    private async void B_Load_Click(object sender, EventArgs e)
    {
        string file = TB_FileName.Text;
        if (!File.Exists(file))
        {
            MessageBox.Show("文件不存在！", "错误");
            return;
        }
        try
        {
            await Task.Run(() => LoadImage(file));
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
        finally
        {
            PB_Preview.Image = BMP?.Bitmap;
        }
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
        if (!BMP.HasValue)
        {
            MessageBox.Show("请先加载图片！");
            return;
        }
        Shuffler.Seed = (uint)NUD_Seed.Value;
        Shuffler.XorshiftX = (int)NUD_X.Value;
        Shuffler.XorshiftY = (int)NUD_Y.Value;
        Shuffler.XorshiftZ = (int)NUD_Z.Value;
        Shuffler.XorshiftStarMultiplier = (ulong)NUD_Multiplier.Value;
        await Task.Run(Shuffle);
        PB_Preview.Refresh();
    }

    private async void B_ReverseShuffle_Click(object sender, EventArgs e)
    {
        if (!BMP.HasValue)
        {
            MessageBox.Show("请先加载图片！");
            return;
        }
        Shuffler.Seed = (uint)NUD_Seed.Value;
        Shuffler.XorshiftX = (int)NUD_X.Value;
        Shuffler.XorshiftY = (int)NUD_Y.Value;
        Shuffler.XorshiftZ = (int)NUD_Z.Value;
        Shuffler.XorshiftStarMultiplier = (ulong)NUD_Multiplier.Value;
        await Task.Run(ReverseShuffle);
        PB_Preview.Refresh();
    }

    private void B_Save_Click(object sender, EventArgs e)
    {
        if (!BMP.HasValue)
        {
            MessageBox.Show("请先加载图片！");
            return;
        }
        if (SFD.ShowDialog() == DialogResult.OK)
        {
            string file = SFD.FileName;
            try
            {
                BMP.Value.Bitmap.Save(
                    file,
                    SFD.FilterIndex switch
                    {
                        1 => ImageFormat.Png,
                        2 => ImageFormat.Bmp,
                        3 => ImageFormat.Tiff,
                        _ => ImageFormat.Png
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
}