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

    private void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Button Add Clicked");
        Console.WriteLine($"{textBoxLink.Text}");
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
    }

    private void FolderBrowserDialogTarget_HelpRequest(object sender, EventArgs e)
    {

    }
}
