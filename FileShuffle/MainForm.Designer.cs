namespace FileShuffle;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        P_Controls = new Panel();
        B_Save = new Button();
        B_ReverseShuffle = new Button();
        B_Shuffle = new Button();
        P_Placeholder = new Panel();
        NUD_Multiplier = new NumericUpDown();
        L_Multiplier = new Label();
        NUD_Z = new NumericUpDown();
        L_Z = new Label();
        NUD_Y = new NumericUpDown();
        L_Y = new Label();
        NUD_X = new NumericUpDown();
        L_X = new Label();
        NUD_Seed = new NumericUpDown();
        L_Seed = new Label();
        B_Reset = new Button();
        B_Load = new Button();
        CB_Preview = new CheckBox();
        CB_Encoding = new ComboBox();
        L_Encoding = new Label();
        RB_TextElementMode = new RadioButton();
        RB_TextMode = new RadioButton();
        RB_BinaryMode = new RadioButton();
        TB_FileName = new TextBox();
        B_Browse = new Button();
        L_FileName = new Label();
        TB_Preview = new TextBox();
        P_Controls.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Multiplier).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Z).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_X).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Seed).BeginInit();
        SuspendLayout();
        // 
        // P_Controls
        // 
        P_Controls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        P_Controls.AutoScroll = true;
        P_Controls.Controls.Add(B_Save);
        P_Controls.Controls.Add(B_ReverseShuffle);
        P_Controls.Controls.Add(B_Shuffle);
        P_Controls.Controls.Add(P_Placeholder);
        P_Controls.Controls.Add(NUD_Multiplier);
        P_Controls.Controls.Add(L_Multiplier);
        P_Controls.Controls.Add(NUD_Z);
        P_Controls.Controls.Add(L_Z);
        P_Controls.Controls.Add(NUD_Y);
        P_Controls.Controls.Add(L_Y);
        P_Controls.Controls.Add(NUD_X);
        P_Controls.Controls.Add(L_X);
        P_Controls.Controls.Add(NUD_Seed);
        P_Controls.Controls.Add(L_Seed);
        P_Controls.Controls.Add(B_Reset);
        P_Controls.Controls.Add(B_Load);
        P_Controls.Controls.Add(CB_Preview);
        P_Controls.Controls.Add(CB_Encoding);
        P_Controls.Controls.Add(L_Encoding);
        P_Controls.Controls.Add(RB_TextElementMode);
        P_Controls.Controls.Add(RB_TextMode);
        P_Controls.Controls.Add(RB_BinaryMode);
        P_Controls.Controls.Add(TB_FileName);
        P_Controls.Controls.Add(B_Browse);
        P_Controls.Controls.Add(L_FileName);
        P_Controls.Location = new Point(12, 12);
        P_Controls.Name = "P_Controls";
        P_Controls.Size = new Size(298, 901);
        P_Controls.TabIndex = 1;
        // 
        // B_Save
        // 
        B_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_Save.Location = new Point(0, 861);
        B_Save.Name = "B_Save";
        B_Save.Size = new Size(298, 40);
        B_Save.TabIndex = 26;
        B_Save.Text = "保存";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        // 
        // B_ReverseShuffle
        // 
        B_ReverseShuffle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_ReverseShuffle.Location = new Point(0, 815);
        B_ReverseShuffle.Name = "B_ReverseShuffle";
        B_ReverseShuffle.Size = new Size(298, 40);
        B_ReverseShuffle.TabIndex = 25;
        B_ReverseShuffle.Text = "反向打乱";
        B_ReverseShuffle.UseVisualStyleBackColor = true;
        B_ReverseShuffle.Click += B_ReverseShuffle_Click;
        // 
        // B_Shuffle
        // 
        B_Shuffle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_Shuffle.Location = new Point(0, 769);
        B_Shuffle.Name = "B_Shuffle";
        B_Shuffle.Size = new Size(298, 40);
        B_Shuffle.TabIndex = 24;
        B_Shuffle.Text = "打乱";
        B_Shuffle.UseVisualStyleBackColor = true;
        B_Shuffle.Click += B_Shuffle_Click;
        // 
        // P_Placeholder
        // 
        P_Placeholder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        P_Placeholder.Location = new Point(0, 740);
        P_Placeholder.Name = "P_Placeholder";
        P_Placeholder.Size = new Size(298, 132);
        P_Placeholder.TabIndex = 23;
        // 
        // NUD_Multiplier
        // 
        NUD_Multiplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Multiplier.Location = new Point(0, 700);
        NUD_Multiplier.Maximum = new decimal(new int[] { -1, -1, 0, 0 });
        NUD_Multiplier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_Multiplier.Name = "NUD_Multiplier";
        NUD_Multiplier.Size = new Size(298, 34);
        NUD_Multiplier.TabIndex = 22;
        NUD_Multiplier.Value = new decimal(new int[] { 1332534557, 625341585, 0, 0 });
        // 
        // L_Multiplier
        // 
        L_Multiplier.AutoSize = true;
        L_Multiplier.Location = new Point(0, 669);
        L_Multiplier.Name = "L_Multiplier";
        L_Multiplier.Size = new Size(54, 28);
        L_Multiplier.TabIndex = 21;
        L_Multiplier.Text = "乘数";
        // 
        // NUD_Z
        // 
        NUD_Z.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Z.Location = new Point(0, 632);
        NUD_Z.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_Z.Name = "NUD_Z";
        NUD_Z.Size = new Size(298, 34);
        NUD_Z.TabIndex = 20;
        NUD_Z.Value = new decimal(new int[] { 27, 0, 0, 0 });
        // 
        // L_Z
        // 
        L_Z.AutoSize = true;
        L_Z.Location = new Point(0, 601);
        L_Z.Name = "L_Z";
        L_Z.Size = new Size(25, 28);
        L_Z.TabIndex = 19;
        L_Z.Text = "Z";
        // 
        // NUD_Y
        // 
        NUD_Y.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Y.Location = new Point(0, 564);
        NUD_Y.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_Y.Name = "NUD_Y";
        NUD_Y.Size = new Size(298, 34);
        NUD_Y.TabIndex = 18;
        NUD_Y.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // L_Y
        // 
        L_Y.AutoSize = true;
        L_Y.Location = new Point(0, 533);
        L_Y.Name = "L_Y";
        L_Y.Size = new Size(25, 28);
        L_Y.TabIndex = 17;
        L_Y.Text = "Y";
        // 
        // NUD_X
        // 
        NUD_X.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_X.Location = new Point(0, 496);
        NUD_X.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_X.Name = "NUD_X";
        NUD_X.Size = new Size(298, 34);
        NUD_X.TabIndex = 16;
        NUD_X.Value = new decimal(new int[] { 12, 0, 0, 0 });
        // 
        // L_X
        // 
        L_X.AutoSize = true;
        L_X.Location = new Point(0, 465);
        L_X.Name = "L_X";
        L_X.Size = new Size(26, 28);
        L_X.TabIndex = 15;
        L_X.Text = "X";
        // 
        // NUD_Seed
        // 
        NUD_Seed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Seed.Location = new Point(0, 428);
        NUD_Seed.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
        NUD_Seed.Name = "NUD_Seed";
        NUD_Seed.Size = new Size(298, 34);
        NUD_Seed.TabIndex = 14;
        NUD_Seed.Value = new decimal(new int[] { 233333, 0, 0, 0 });
        // 
        // L_Seed
        // 
        L_Seed.AutoSize = true;
        L_Seed.Location = new Point(0, 397);
        L_Seed.Name = "L_Seed";
        L_Seed.Size = new Size(54, 28);
        L_Seed.TabIndex = 13;
        L_Seed.Text = "种子";
        // 
        // B_Reset
        // 
        B_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        B_Reset.Location = new Point(0, 354);
        B_Reset.Name = "B_Reset";
        B_Reset.Size = new Size(298, 40);
        B_Reset.TabIndex = 12;
        B_Reset.Text = "使用默认参数";
        B_Reset.UseVisualStyleBackColor = true;
        B_Reset.Click += B_Reset_Click;
        // 
        // B_Load
        // 
        B_Load.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        B_Load.Location = new Point(0, 308);
        B_Load.Name = "B_Load";
        B_Load.Size = new Size(298, 40);
        B_Load.TabIndex = 11;
        B_Load.Text = "加载";
        B_Load.UseVisualStyleBackColor = true;
        B_Load.Click += B_Load_Click;
        // 
        // CB_Preview
        // 
        CB_Preview.AutoSize = true;
        CB_Preview.Location = new Point(0, 270);
        CB_Preview.Name = "CB_Preview";
        CB_Preview.Size = new Size(80, 32);
        CB_Preview.TabIndex = 10;
        CB_Preview.Text = "预览";
        CB_Preview.UseVisualStyleBackColor = true;
        CB_Preview.CheckedChanged += X_Changed;
        // 
        // CB_Encoding
        // 
        CB_Encoding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CB_Encoding.FormattingEnabled = true;
        CB_Encoding.Items.AddRange(new object[] { "utf-8", "utf-16", "utf-16BE", "utf-32", "utf-32BE", "gb2312", "gb18030", "big5", "shift_jis", "iso-8859-1", "windows-1252" });
        CB_Encoding.Location = new Point(0, 228);
        CB_Encoding.Name = "CB_Encoding";
        CB_Encoding.Size = new Size(298, 36);
        CB_Encoding.TabIndex = 9;
        CB_Encoding.Text = "utf-8";
        // 
        // L_Encoding
        // 
        L_Encoding.AutoSize = true;
        L_Encoding.Location = new Point(0, 197);
        L_Encoding.Name = "L_Encoding";
        L_Encoding.Size = new Size(54, 28);
        L_Encoding.TabIndex = 8;
        L_Encoding.Text = "编码";
        // 
        // RB_TextElementMode
        // 
        RB_TextElementMode.AutoSize = true;
        RB_TextElementMode.Location = new Point(0, 162);
        RB_TextElementMode.Name = "RB_TextElementMode";
        RB_TextElementMode.Size = new Size(163, 32);
        RB_TextElementMode.TabIndex = 7;
        RB_TextElementMode.Text = "文本元素模式";
        RB_TextElementMode.UseVisualStyleBackColor = true;
        RB_TextElementMode.CheckedChanged += X_Changed;
        // 
        // RB_TextMode
        // 
        RB_TextMode.AutoSize = true;
        RB_TextMode.Location = new Point(0, 124);
        RB_TextMode.Name = "RB_TextMode";
        RB_TextMode.Size = new Size(121, 32);
        RB_TextMode.TabIndex = 6;
        RB_TextMode.Text = "文本模式";
        RB_TextMode.UseVisualStyleBackColor = true;
        RB_TextMode.CheckedChanged += X_Changed;
        // 
        // RB_BinaryMode
        // 
        RB_BinaryMode.AutoSize = true;
        RB_BinaryMode.Checked = true;
        RB_BinaryMode.Location = new Point(0, 86);
        RB_BinaryMode.Name = "RB_BinaryMode";
        RB_BinaryMode.Size = new Size(142, 32);
        RB_BinaryMode.TabIndex = 5;
        RB_BinaryMode.TabStop = true;
        RB_BinaryMode.Text = "二进制模式";
        RB_BinaryMode.UseVisualStyleBackColor = true;
        RB_BinaryMode.CheckedChanged += X_Changed;
        // 
        // TB_FileName
        // 
        TB_FileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TB_FileName.Location = new Point(0, 46);
        TB_FileName.Name = "TB_FileName";
        TB_FileName.Size = new Size(298, 34);
        TB_FileName.TabIndex = 4;
        // 
        // B_Browse
        // 
        B_Browse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        B_Browse.Location = new Point(215, 0);
        B_Browse.Name = "B_Browse";
        B_Browse.Size = new Size(83, 40);
        B_Browse.TabIndex = 3;
        B_Browse.Text = "浏览";
        B_Browse.UseVisualStyleBackColor = true;
        B_Browse.Click += B_Browse_Click;
        // 
        // L_FileName
        // 
        L_FileName.AutoSize = true;
        L_FileName.Location = new Point(0, 6);
        L_FileName.Name = "L_FileName";
        L_FileName.Size = new Size(54, 28);
        L_FileName.TabIndex = 2;
        L_FileName.Text = "文件";
        // 
        // TB_Preview
        // 
        TB_Preview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        TB_Preview.Location = new Point(316, 12);
        TB_Preview.Multiline = true;
        TB_Preview.Name = "TB_Preview";
        TB_Preview.ScrollBars = ScrollBars.Vertical;
        TB_Preview.Size = new Size(704, 901);
        TB_Preview.TabIndex = 27;
        TB_Preview.TextChanged += TB_Preview_TextChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(13F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1032, 925);
        Controls.Add(TB_Preview);
        Controls.Add(P_Controls);
        Name = "MainForm";
        Text = "文件打乱";
        DragDrop += MainForm_DragDrop;
        DragEnter += MainForm_DragEnter;
        P_Controls.ResumeLayout(false);
        P_Controls.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Multiplier).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Z).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_X).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Seed).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel P_Controls;
    private Label L_FileName;
    private Button B_Browse;
    private TextBox TB_FileName;
    private CheckBox CB_Preview;
    private Label L_Encoding;
    private ComboBox CB_Encoding;
    private RadioButton RB_BinaryMode;
    private RadioButton RB_TextMode;
    private RadioButton RB_TextElementMode;
    private Button B_Load;
    private Button B_Reset;
    private Label L_Seed;
    private NumericUpDown NUD_Seed;
    private Label L_X;
    private NumericUpDown NUD_X;
    private Label L_Y;
    private NumericUpDown NUD_Y;
    private Label L_Z;
    private NumericUpDown NUD_Z;
    private Label L_Multiplier;
    private NumericUpDown NUD_Multiplier;
    private Panel P_Placeholder;
    private Button B_Shuffle;
    private Button B_ReverseShuffle;
    private Button B_Save;
    private TextBox TB_Preview;
}
