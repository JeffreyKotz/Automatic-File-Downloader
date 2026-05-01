namespace AutomaticFileDownloader;

partial class AutoDownloaderForm
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
        fileSaveDialog = new SaveFileDialog();
        buttonStart = new Button();
        buttonCancel = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        checkBoxAutoStart = new CheckBox();
        clearDoneButton = new Button();
        buttonSetTarget = new Button();
        textBoxTarget = new TextBox();
        textBoxLink = new TextBox();
        buttonAdd = new Button();
        panel1 = new Panel();
        downloadsTableLayoutPanel = new TableLayoutPanel();
        flowLayoutPanelDownloads = new FlowLayoutPanel();
        label1 = new Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        flowLayoutPanelDownloads.SuspendLayout();
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        buttonStart.BackColor = Color.FromArgb(32, 32, 32);
        buttonStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        buttonStart.ForeColor = Color.White;
        buttonStart.Location = new Point(2, 2);
        buttonStart.Margin = new Padding(2);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(130, 36);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = false;
        buttonStart.MouseCaptureChanged += ButtonStart_MouseCaptureChanged;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        buttonCancel.BackColor = Color.FromArgb(32, 32, 32);
        buttonCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        buttonCancel.ForeColor = Color.White;
        buttonCancel.Location = new Point(2, 42);
        buttonCancel.Margin = new Padding(2);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(130, 36);
        buttonCancel.TabIndex = 1;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = false;
        buttonCancel.MouseClick += ButtonCancel_MouseClick;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Controls.Add(buttonSetTarget, 1, 2);
        tableLayoutPanel1.Controls.Add(textBoxTarget, 0, 2);
        tableLayoutPanel1.Controls.Add(textBoxLink, 0, 1);
        tableLayoutPanel1.Controls.Add(buttonAdd, 1, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.Size = new Size(615, 641);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(checkBoxAutoStart, 0, 3);
        tableLayoutPanel2.Controls.Add(buttonStart, 0, 0);
        tableLayoutPanel2.Controls.Add(clearDoneButton, 0, 2);
        tableLayoutPanel2.Controls.Add(buttonCancel, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(478, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 4;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new Size(134, 555);
        tableLayoutPanel2.TabIndex = 9;
        // 
        // checkBoxAutoStart
        // 
        checkBoxAutoStart.Anchor = AnchorStyles.Bottom;
        checkBoxAutoStart.AutoSize = true;
        checkBoxAutoStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        checkBoxAutoStart.ForeColor = Color.White;
        checkBoxAutoStart.Location = new Point(5, 523);
        checkBoxAutoStart.Name = "checkBoxAutoStart";
        checkBoxAutoStart.Size = new Size(124, 29);
        checkBoxAutoStart.TabIndex = 5;
        checkBoxAutoStart.Text = "Auto Start";
        checkBoxAutoStart.UseVisualStyleBackColor = true;
        // 
        // clearDoneButton
        // 
        clearDoneButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        clearDoneButton.BackColor = Color.FromArgb(32, 32, 32);
        clearDoneButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        clearDoneButton.ForeColor = Color.White;
        clearDoneButton.Location = new Point(3, 83);
        clearDoneButton.Name = "clearDoneButton";
        clearDoneButton.Size = new Size(128, 34);
        clearDoneButton.TabIndex = 8;
        clearDoneButton.Text = "Clear";
        clearDoneButton.UseVisualStyleBackColor = false;
        clearDoneButton.MouseClick += clearDoneButton_MouseClick;
        // 
        // buttonSetTarget
        // 
        buttonSetTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        buttonSetTarget.BackColor = Color.FromArgb(32, 32, 32);
        buttonSetTarget.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonSetTarget.ForeColor = Color.White;
        buttonSetTarget.Location = new Point(477, 603);
        buttonSetTarget.Margin = new Padding(2);
        buttonSetTarget.Name = "buttonSetTarget";
        buttonSetTarget.Size = new Size(136, 34);
        buttonSetTarget.TabIndex = 6;
        buttonSetTarget.Text = "Set Target";
        buttonSetTarget.UseVisualStyleBackColor = false;
        buttonSetTarget.MouseClick += ButtonSetTarget_MouseClick;
        // 
        // textBoxTarget
        // 
        textBoxTarget.BackColor = Color.FromArgb(20, 20, 20);
        textBoxTarget.BorderStyle = BorderStyle.FixedSingle;
        textBoxTarget.Dock = DockStyle.Top;
        textBoxTarget.ForeColor = Color.White;
        textBoxTarget.Location = new Point(2, 603);
        textBoxTarget.Margin = new Padding(2);
        textBoxTarget.Name = "textBoxTarget";
        textBoxTarget.PlaceholderText = "File Path (e.g. /home/user/Downloads/file.txt)";
        textBoxTarget.Size = new Size(471, 31);
        textBoxTarget.TabIndex = 7;
        // 
        // textBoxLink
        // 
        textBoxLink.BackColor = Color.FromArgb(20, 20, 20);
        textBoxLink.BorderStyle = BorderStyle.FixedSingle;
        textBoxLink.Dock = DockStyle.Bottom;
        textBoxLink.ForeColor = Color.White;
        textBoxLink.Location = new Point(2, 568);
        textBoxLink.Margin = new Padding(2);
        textBoxLink.Name = "textBoxLink";
        textBoxLink.PlaceholderText = "Web Address (e.g. https://www.google.com)";
        textBoxLink.Size = new Size(471, 31);
        textBoxLink.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        buttonAdd.BackColor = Color.FromArgb(32, 32, 32);
        buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonAdd.ForeColor = Color.White;
        buttonAdd.Location = new Point(477, 565);
        buttonAdd.Margin = new Padding(2);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(136, 34);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        buttonAdd.MouseClick += ButtonAdd_MouseClick;
        // 
        // panel1
        // 
        panel1.AutoScroll = true;
        panel1.BackColor = Color.FromArgb(64, 64, 64);
        panel1.Controls.Add(downloadsTableLayoutPanel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(469, 555);
        panel1.TabIndex = 10;
        // 
        // downloadsTableLayoutPanel
        // 
        downloadsTableLayoutPanel.AutoSize = true;
        downloadsTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        downloadsTableLayoutPanel.BackColor = Color.FromArgb(64, 64, 64);
        downloadsTableLayoutPanel.ColumnCount = 1;
        downloadsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        downloadsTableLayoutPanel.Dock = DockStyle.Top;
        downloadsTableLayoutPanel.Location = new Point(0, 0);
        downloadsTableLayoutPanel.Name = "downloadsTableLayoutPanel";
        downloadsTableLayoutPanel.RowCount = 1;
        downloadsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        downloadsTableLayoutPanel.Size = new Size(469, 0);
        downloadsTableLayoutPanel.TabIndex = 0;
        // 
        // flowLayoutPanelDownloads
        // 
        flowLayoutPanelDownloads.AutoScroll = true;
        flowLayoutPanelDownloads.AutoScrollMargin = new Size(1, 0);
        flowLayoutPanelDownloads.AutoScrollMinSize = new Size(1, 0);
        flowLayoutPanelDownloads.BackColor = Color.FromArgb(64, 64, 64);
        flowLayoutPanelDownloads.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanelDownloads.Controls.Add(label1);
        flowLayoutPanelDownloads.Dock = DockStyle.Fill;
        flowLayoutPanelDownloads.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanelDownloads.Location = new Point(0, 0);
        flowLayoutPanelDownloads.Name = "flowLayoutPanelDownloads";
        flowLayoutPanelDownloads.Size = new Size(615, 641);
        flowLayoutPanelDownloads.TabIndex = 4;
        flowLayoutPanelDownloads.WrapContents = false;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top;
        label1.AutoEllipsis = true;
        label1.AutoSize = true;
        label1.BackColor = Color.Black;
        label1.ForeColor = Color.White;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // AutoDownloaderForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(32, 32, 32);
        ClientSize = new Size(615, 641);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(flowLayoutPanelDownloads);
        Margin = new Padding(2);
        MinimumSize = new Size(637, 697);
        Name = "AutoDownloaderForm";
        Text = "Automatic File Downloader";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        flowLayoutPanelDownloads.ResumeLayout(false);
        flowLayoutPanelDownloads.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private SaveFileDialog fileSaveDialog;
    private Button buttonStart;
    private Button buttonCancel;
    private TableLayoutPanel tableLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanelDownloads;
    private Button buttonSetTarget;
    private TextBox textBoxTarget;
    private TextBox textBoxLink;
    private Button buttonAdd;
    private CheckBox checkBoxAutoStart;
    private Button clearDoneButton;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label1;
    private Panel panel1;
    private TableLayoutPanel downloadsTableLayoutPanel;
}
