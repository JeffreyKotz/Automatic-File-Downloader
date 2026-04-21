namespace AutomaticFileDownloader;

partial class Form1
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
        flowLayoutPanel1 = new FlowLayoutPanel();
        checkBox1 = new CheckBox();
        buttonSetDirectory = new Button();
        textBoxDirectory = new TextBox();
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
        buttonStart.Click += button1_Click;
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
        // 
        // textBoxLink
        // 
        textBoxLink.Location = new Point(7, 566);
        textBoxLink.Margin = new Padding(2);
        textBoxLink.Name = "textBoxLink";
        textBoxLink.Size = new Size(478, 31);
        textBoxLink.TabIndex = 2;
        textBoxLink.TextChanged += textBox1_TextChanged;
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
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.AutoScrollMargin = new Size(1, 0);
        flowLayoutPanel1.AutoScrollMinSize = new Size(1, 0);
        flowLayoutPanel1.BackColor = SystemColors.Window;
        flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(8, 9);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(477, 552);
        flowLayoutPanel1.TabIndex = 4;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        checkBox1.Location = new Point(491, 521);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(124, 29);
        checkBox1.TabIndex = 5;
        checkBox1.Text = "Auto Start";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
        // 
        // buttonSetDirectory
        // 
        buttonSetDirectory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonSetDirectory.Location = new Point(491, 601);
        buttonSetDirectory.Margin = new Padding(2);
        buttonSetDirectory.Name = "buttonSetDirectory";
        buttonSetDirectory.Size = new Size(115, 36);
        buttonSetDirectory.TabIndex = 6;
        buttonSetDirectory.Text = "Set Target";
        buttonSetDirectory.UseVisualStyleBackColor = true;
        // 
        // textBoxDirectory
        // 
        textBoxDirectory.Location = new Point(7, 601);
        textBoxDirectory.Margin = new Padding(2);
        textBoxDirectory.Name = "textBoxDirectory";
        textBoxDirectory.Size = new Size(478, 31);
        textBoxDirectory.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(615, 641);
        Controls.Add(textBoxDirectory);
        Controls.Add(buttonSetDirectory);
        Controls.Add(checkBox1);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(buttonAdd);
        Controls.Add(textBoxLink);
        Controls.Add(buttonCancel);
        Controls.Add(buttonStart);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Automatic File Downloader";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonStart;
    private Button buttonCancel;
    private TextBox textBoxLink;
    private Button buttonAdd;
    private FlowLayoutPanel flowLayoutPanel1;
    private CheckBox checkBox1;
    private Button buttonSetDirectory;
    private TextBox textBoxDirectory;
}
