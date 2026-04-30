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
        buttonStart = new Button();
        buttonCancel = new Button();
        textBoxLink = new TextBox();
        buttonAdd = new Button();
        flowLayoutPanelDownloads = new FlowLayoutPanel();
        checkBoxAutoStart = new CheckBox();
        buttonSetTarget = new Button();
        textBoxTarget = new TextBox();
        clearDoneButton = new Button();
        fileSaveDialog = new SaveFileDialog();
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        buttonStart.Location = new Point(491, 9);
        buttonStart.Margin = new Padding(2);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(115, 36);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.MouseCaptureChanged += ButtonStart_MouseCaptureChanged;
        // 
        // buttonCancel
        // 
        buttonCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        buttonCancel.Location = new Point(491, 50);
        buttonCancel.Margin = new Padding(2);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(115, 36);
        buttonCancel.TabIndex = 1;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.MouseClick += ButtonCancel_MouseClick;
        // 
        // textBoxLink
        // 
        textBoxLink.BorderStyle = BorderStyle.FixedSingle;
        textBoxLink.Location = new Point(7, 566);
        textBoxLink.Margin = new Padding(2);
        textBoxLink.Name = "textBoxLink";
        textBoxLink.PlaceholderText = "Web Address (e.g. https://www.google.com)";
        textBoxLink.Size = new Size(478, 31);
        textBoxLink.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonAdd.Location = new Point(491, 561);
        buttonAdd.Margin = new Padding(2);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(115, 36);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.MouseClick += ButtonAdd_MouseClick;
        // 
        // flowLayoutPanelDownloads
        // 
        flowLayoutPanelDownloads.Anchor = AnchorStyles.Top;
        flowLayoutPanelDownloads.AutoScroll = true;
        flowLayoutPanelDownloads.AutoScrollMargin = new Size(1, 0);
        flowLayoutPanelDownloads.AutoScrollMinSize = new Size(1, 0);
        flowLayoutPanelDownloads.BackColor = SystemColors.Window;
        flowLayoutPanelDownloads.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanelDownloads.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanelDownloads.Location = new Point(8, 9);
        flowLayoutPanelDownloads.Name = "flowLayoutPanelDownloads";
        flowLayoutPanelDownloads.Size = new Size(477, 552);
        flowLayoutPanelDownloads.TabIndex = 4;
        flowLayoutPanelDownloads.WrapContents = false;
        // 
        // checkBoxAutoStart
        // 
        checkBoxAutoStart.AutoSize = true;
        checkBoxAutoStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        checkBoxAutoStart.Location = new Point(491, 521);
        checkBoxAutoStart.Name = "checkBoxAutoStart";
        checkBoxAutoStart.Size = new Size(124, 29);
        checkBoxAutoStart.TabIndex = 5;
        checkBoxAutoStart.Text = "Auto Start";
        checkBoxAutoStart.UseVisualStyleBackColor = true;
        // 
        // buttonSetTarget
        // 
        buttonSetTarget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonSetTarget.Location = new Point(491, 601);
        buttonSetTarget.Margin = new Padding(2);
        buttonSetTarget.Name = "buttonSetTarget";
        buttonSetTarget.Size = new Size(115, 36);
        buttonSetTarget.TabIndex = 6;
        buttonSetTarget.Text = "Set Target";
        buttonSetTarget.UseVisualStyleBackColor = true;
        buttonSetTarget.MouseClick += ButtonSetTarget_MouseClick;
        // 
        // textBoxTarget
        // 
        textBoxTarget.BorderStyle = BorderStyle.FixedSingle;
        textBoxTarget.Location = new Point(8, 601);
        textBoxTarget.Margin = new Padding(2);
        textBoxTarget.Name = "textBoxTarget";
        textBoxTarget.PlaceholderText = "File Path (e.g. /home/user/Downloads/file.txt)";
        textBoxTarget.Size = new Size(478, 31);
        textBoxTarget.TabIndex = 7;
        // 
        // clearDoneButton
        // 
        clearDoneButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        clearDoneButton.Location = new Point(491, 91);
        clearDoneButton.Name = "clearDoneButton";
        clearDoneButton.Size = new Size(112, 34);
        clearDoneButton.TabIndex = 8;
        clearDoneButton.Text = "Clear";
        clearDoneButton.UseVisualStyleBackColor = true;
        clearDoneButton.MouseClick += clearDoneButton_MouseClick;
        // 
        // fileSaveDialog
        // 
        fileSaveDialog.FileOk += fileSaveDialog_FileOk;
        // 
        // AutoDownloaderForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(615, 641);
        Controls.Add(clearDoneButton);
        Controls.Add(textBoxTarget);
        Controls.Add(buttonSetTarget);
        Controls.Add(checkBoxAutoStart);
        Controls.Add(flowLayoutPanelDownloads);
        Controls.Add(buttonAdd);
        Controls.Add(textBoxLink);
        Controls.Add(buttonCancel);
        Controls.Add(buttonStart);
        Margin = new Padding(2);
        Name = "AutoDownloaderForm";
        Text = "Automatic File Downloader";
        Load += AutoDownloaderForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonStart;
	private Button buttonCancel;
	private TextBox textBoxLink;
	private Button buttonAdd;
	private FlowLayoutPanel flowLayoutPanelDownloads;
	private CheckBox checkBoxAutoStart;
	private Button buttonSetTarget;
    private TextBox textBoxTarget;
    private Button clearDoneButton;
    private SaveFileDialog fileSaveDialog;
}
