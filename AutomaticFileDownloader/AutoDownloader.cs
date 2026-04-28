using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomaticFileDownloader;

public partial class AutoDownloaderForm : Form
{
    List<Panel> downloadPanels = new List<Panel>();

    public AutoDownloaderForm()
    {
        InitializeComponent();
    }

    private void AutoDownloaderForm_Load(object sender, EventArgs e)
    {
        Console.WriteLine("Form Load");
    }

    private void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Button Add Clicked");
        Console.WriteLine($"{textBoxLink.Text}");

        Panel panel = new Panel()
        {
            //Location = new Point(50, 50),
            AutoSize = true,
            BackColor = Color.Transparent,
        };
        panel.Controls.Add(new Label()
        {
            Location = new Point(2, 2),
            AutoSize = true,
            ForeColor = Color.Black,
            Text = "Hello World"
        });
        panel.Controls.Add(new System.Windows.Forms.ProgressBar()
        {
            Value = 50,
            Size = new Size(435, 30),
        });
        

        flowLayoutPanelDownloads.Controls.Add(panel);
        downloadPanels.Add(panel);
    }

    private void ButtonSetTarget_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Button Set Target Clicked");

        if (folderBrowserDialogTarget.ShowDialog() == DialogResult.OK)
        {
            textBoxTarget.Text = folderBrowserDialogTarget.SelectedPath;
        }
    }

    private void ButtonStart_MouseCaptureChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Button Start Clicked");
    }

    private void ButtonCancel_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Button Cancel Clicked");
        DownloadManager.Test();
    }

    private void FolderBrowserDialogTarget_HelpRequest(object sender, EventArgs e)
    {

    }

    private void clearDoneButton_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Clear Complete Clicked");
    }
}
