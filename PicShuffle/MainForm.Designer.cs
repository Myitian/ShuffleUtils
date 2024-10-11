namespace PicShuffle;

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
        B_Shuffle = new Button();
        B_ReverseShuffle = new Button();
        B_Save = new Button();
        L_FileName = new Label();
        B_Browse = new Button();
        TB_FileName = new TextBox();
        B_Load = new Button();
        B_Reset = new Button();
        L_Seed = new Label();
        NUD_Seed = new NumericUpDown();
        L_Z = new Label();
        NUD_Z = new NumericUpDown();
        L_Y = new Label();
        NUD_Y = new NumericUpDown();
        L_X = new Label();
        NUD_X = new NumericUpDown();
        L_Multiplier = new Label();
        NUD_Multiplier = new NumericUpDown();
        P_Placeholder = new Panel();
        P_Preview = new Panel();
        PB_Preview = new PictureBox();
        P_Controls.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Seed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Z).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_X).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Multiplier).BeginInit();
        P_Preview.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_Preview).BeginInit();
        SuspendLayout();
        // 
        // P_Controls
        // 
        P_Controls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        P_Controls.AutoScroll = true;
        P_Controls.Controls.Add(B_Shuffle);
        P_Controls.Controls.Add(B_ReverseShuffle);
        P_Controls.Controls.Add(B_Save);
        P_Controls.Controls.Add(L_FileName);
        P_Controls.Controls.Add(B_Browse);
        P_Controls.Controls.Add(TB_FileName);
        P_Controls.Controls.Add(B_Load);
        P_Controls.Controls.Add(B_Reset);
        P_Controls.Controls.Add(L_Seed);
        P_Controls.Controls.Add(NUD_Seed);
        P_Controls.Controls.Add(L_Z);
        P_Controls.Controls.Add(NUD_Z);
        P_Controls.Controls.Add(L_Y);
        P_Controls.Controls.Add(NUD_Y);
        P_Controls.Controls.Add(L_X);
        P_Controls.Controls.Add(NUD_X);
        P_Controls.Controls.Add(L_Multiplier);
        P_Controls.Controls.Add(NUD_Multiplier);
        P_Controls.Controls.Add(P_Placeholder);
        P_Controls.Location = new Point(12, 12);
        P_Controls.Name = "P_Controls";
        P_Controls.Size = new Size(191, 712);
        P_Controls.TabIndex = 0;
        // 
        // B_Shuffle
        // 
        B_Shuffle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_Shuffle.Location = new Point(0, 580);
        B_Shuffle.Name = "B_Shuffle";
        B_Shuffle.Size = new Size(191, 40);
        B_Shuffle.TabIndex = 17;
        B_Shuffle.Text = "打乱";
        B_Shuffle.UseVisualStyleBackColor = true;
        B_Shuffle.Click += B_Shuffle_Click;
        // 
        // B_ReverseShuffle
        // 
        B_ReverseShuffle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_ReverseShuffle.Location = new Point(0, 626);
        B_ReverseShuffle.Name = "B_ReverseShuffle";
        B_ReverseShuffle.Size = new Size(191, 40);
        B_ReverseShuffle.TabIndex = 18;
        B_ReverseShuffle.Text = "反向打乱";
        B_ReverseShuffle.UseVisualStyleBackColor = true;
        B_ReverseShuffle.Click += B_ReverseShuffle_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        B_Save.Location = new Point(0, 672);
        B_Save.Name = "B_Save";
        B_Save.Size = new Size(191, 40);
        B_Save.TabIndex = 19;
        B_Save.Text = "保存";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        // 
        // L_FileName
        // 
        L_FileName.AutoSize = true;
        L_FileName.Location = new Point(0, 6);
        L_FileName.Name = "L_FileName";
        L_FileName.Size = new Size(54, 28);
        L_FileName.TabIndex = 1;
        L_FileName.Text = "文件";
        // 
        // B_Browse
        // 
        B_Browse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        B_Browse.Location = new Point(108, 0);
        B_Browse.Name = "B_Browse";
        B_Browse.Size = new Size(83, 40);
        B_Browse.TabIndex = 2;
        B_Browse.Text = "浏览";
        B_Browse.UseVisualStyleBackColor = true;
        B_Browse.Click += B_Browse_Click;
        // 
        // TB_FileName
        // 
        TB_FileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TB_FileName.Location = new Point(0, 46);
        TB_FileName.Name = "TB_FileName";
        TB_FileName.Size = new Size(191, 34);
        TB_FileName.TabIndex = 3;
        // 
        // B_Load
        // 
        B_Load.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        B_Load.Location = new Point(0, 86);
        B_Load.Name = "B_Load";
        B_Load.Size = new Size(191, 40);
        B_Load.TabIndex = 4;
        B_Load.Text = "加载";
        B_Load.UseVisualStyleBackColor = true;
        B_Load.Click += B_Load_Click;
        // 
        // B_Reset
        // 
        B_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        B_Reset.Location = new Point(0, 132);
        B_Reset.Name = "B_Reset";
        B_Reset.Size = new Size(191, 40);
        B_Reset.TabIndex = 5;
        B_Reset.Text = "使用默认参数";
        B_Reset.UseVisualStyleBackColor = true;
        B_Reset.Click += B_Reset_Click;
        // 
        // L_Seed
        // 
        L_Seed.AutoSize = true;
        L_Seed.Location = new Point(0, 175);
        L_Seed.Name = "L_Seed";
        L_Seed.Size = new Size(54, 28);
        L_Seed.TabIndex = 6;
        L_Seed.Text = "种子";
        // 
        // NUD_Seed
        // 
        NUD_Seed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Seed.Location = new Point(0, 206);
        NUD_Seed.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
        NUD_Seed.Name = "NUD_Seed";
        NUD_Seed.Size = new Size(191, 34);
        NUD_Seed.TabIndex = 7;
        NUD_Seed.Value = new decimal(new int[] { 233333, 0, 0, 0 });
        // 
        // L_Z
        // 
        L_Z.AutoSize = true;
        L_Z.Location = new Point(0, 379);
        L_Z.Name = "L_Z";
        L_Z.Size = new Size(25, 28);
        L_Z.TabIndex = 12;
        L_Z.Text = "Z";
        // 
        // NUD_Z
        // 
        NUD_Z.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Z.Location = new Point(0, 410);
        NUD_Z.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_Z.Name = "NUD_Z";
        NUD_Z.Size = new Size(191, 34);
        NUD_Z.TabIndex = 13;
        NUD_Z.Value = new decimal(new int[] { 27, 0, 0, 0 });
        // 
        // L_Y
        // 
        L_Y.AutoSize = true;
        L_Y.Location = new Point(0, 311);
        L_Y.Name = "L_Y";
        L_Y.Size = new Size(25, 28);
        L_Y.TabIndex = 10;
        L_Y.Text = "Y";
        // 
        // NUD_Y
        // 
        NUD_Y.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Y.Location = new Point(0, 342);
        NUD_Y.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_Y.Name = "NUD_Y";
        NUD_Y.Size = new Size(191, 34);
        NUD_Y.TabIndex = 11;
        NUD_Y.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // L_X
        // 
        L_X.AutoSize = true;
        L_X.Location = new Point(0, 243);
        L_X.Name = "L_X";
        L_X.Size = new Size(26, 28);
        L_X.TabIndex = 8;
        L_X.Text = "X";
        // 
        // NUD_X
        // 
        NUD_X.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_X.Location = new Point(0, 274);
        NUD_X.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        NUD_X.Name = "NUD_X";
        NUD_X.Size = new Size(191, 34);
        NUD_X.TabIndex = 9;
        NUD_X.Value = new decimal(new int[] { 12, 0, 0, 0 });
        // 
        // L_Multiplier
        // 
        L_Multiplier.AutoSize = true;
        L_Multiplier.Location = new Point(0, 447);
        L_Multiplier.Name = "L_Multiplier";
        L_Multiplier.Size = new Size(54, 28);
        L_Multiplier.TabIndex = 14;
        L_Multiplier.Text = "乘数";
        // 
        // NUD_Multiplier
        // 
        NUD_Multiplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NUD_Multiplier.Location = new Point(0, 478);
        NUD_Multiplier.Maximum = new decimal(new int[] { -1, -1, 0, 0 });
        NUD_Multiplier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_Multiplier.Name = "NUD_Multiplier";
        NUD_Multiplier.Size = new Size(191, 34);
        NUD_Multiplier.TabIndex = 15;
        NUD_Multiplier.Value = new decimal(new int[] { 1332534557, 625341585, 0, 0 });
        // 
        // P_Placeholder
        // 
        P_Placeholder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        P_Placeholder.Location = new Point(0, 518);
        P_Placeholder.Name = "P_Placeholder";
        P_Placeholder.Size = new Size(191, 132);
        P_Placeholder.TabIndex = 16;
        // 
        // P_Preview
        // 
        P_Preview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        P_Preview.AutoScroll = true;
        P_Preview.Controls.Add(PB_Preview);
        P_Preview.Location = new Point(209, 12);
        P_Preview.Name = "P_Preview";
        P_Preview.Size = new Size(655, 712);
        P_Preview.TabIndex = 20;
        // 
        // PB_Preview
        // 
        PB_Preview.Location = new Point(0, 0);
        PB_Preview.Name = "PB_Preview";
        PB_Preview.Size = new Size(32, 32);
        PB_Preview.SizeMode = PictureBoxSizeMode.AutoSize;
        PB_Preview.TabIndex = 21;
        PB_Preview.TabStop = false;
        // 
        // MainForm
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(13F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(876, 736);
        Controls.Add(P_Controls);
        Controls.Add(P_Preview);
        Name = "MainForm";
        Text = "图片打乱";
        DragDrop += MainForm_DragDrop;
        DragEnter += MainForm_DragEnter;
        P_Controls.ResumeLayout(false);
        P_Controls.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Seed).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Z).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_X).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Multiplier).EndInit();
        P_Preview.ResumeLayout(false);
        P_Preview.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_Preview).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel P_Controls;
    private Label L_FileName;
    private Button B_Browse;
    private TextBox TB_FileName;
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
    private Panel P_Preview;
    private PictureBox PB_Preview;
}
