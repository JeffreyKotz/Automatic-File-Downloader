using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomaticFileDownloader;

public partial class AutoDownloaderForm : Form
{
    public AutoDownloaderForm()
    {
        InitializeComponent();
    }

    private void AutoDownloaderForm_Load(object sender, EventArgs e)
    {
        Console.WriteLine("Form Load");
    }

    private async void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Button Add Clicked");

        Panel panel = new Panel()
        {
            AutoSize = true,
        };

        flowLayoutPanelDownloads.Controls.Add(new Label()
        {
            Location = new Point(2, 2),
            AutoSize = true,
            ForeColor = Color.White,
            BackColor = Color.Gray,
            Text = textBoxLink.Text,
            MaximumSize = new Size(400, 30)
        });

        string fileName = textBoxLink.Text.Split("/").Last();
    await Managers.DownloadManager.DownloadFileAsync(textBoxLink.Text, $"{textBoxTarget.Text}\\{fileName}");
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
