using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomaticFileDownloader;

public partial class AutoDownloaderForm : Form
{
    public AutoDownloaderForm()
    {
        InitializeComponent();
    }

    private Utilities.DownloadActions AddDownloadLabel(string labelText)
    {
        Label label = new Label()
        {
            Location = new Point(2, 2),
            AutoSize = true,
            ForeColor = Color.White,
            BackColor = Color.Black,
            Text = labelText,
            MaximumSize = new Size(400, 30)
        };

        flowLayoutPanelDownloads.Controls.Add(label);

        // Set button appearance for different states
        Action downloadStarted = () => { label.BackColor = Color.DarkGoldenrod; };
        Action downloadCancelled = () => { label.BackColor = Color.DarkGray; };
        Action downloadCompleted = () => { label.BackColor = Color.DarkGreen; };
        Action downloadFailed = () => { label.BackColor = Color.DarkRed; };
        Action disposeLabel = () => { label.Dispose(); };

        // Return a set of actions denoting the different download states represented by the label
        return new Utilities.DownloadActions(downloadStarted, downloadCancelled, downloadCompleted, downloadFailed, disposeLabel);

    }

    private void AutoDownloaderForm_Load(object sender, EventArgs e)
    {
    }

    private async void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
    {
        string linkText = textBoxLink.Text;
        string targetFile = textBoxTarget.Text;

        if ( ! Utilities.DownloadHandler.ValidLink(linkText) || ! Utilities.DownloadHandler.ValidFilePath(targetFile))
        {
            MessageBox.Show("Both web address and file path are required to add download.");
        }
        else
        {
            Utilities.DownloadActions actions = AddDownloadLabel(linkText);

            // Queue the download
            Utilities.DownloadHandler.AddDownload(linkText, targetFile, actions);

            // Clear text
            textBoxLink.Text = null;
            textBoxTarget.Text = null;
        }
    }

    private void ButtonSetTarget_MouseClick(object sender, MouseEventArgs e)
    {
        if (fileSaveDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxTarget.Text = fileSaveDialog.FileName;
        }
    }

    private void ButtonStart_MouseCaptureChanged(object sender, EventArgs e)
    {
        Utilities.DownloadHandler.StartDownload();
    }

    private async void ButtonCancel_MouseClick(object sender, MouseEventArgs e)
    {
        await Utilities.DownloadHandler.CancelDownload();
    }

    private void FolderBrowserDialogTarget_HelpRequest(object sender, EventArgs e)
    {

    }
    private void fileSaveDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    private void clearDoneButton_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void clearDoneButton_Click(object sender, EventArgs e)
    {
        Utilities.DownloadHandler.Dispose();
    }
}
