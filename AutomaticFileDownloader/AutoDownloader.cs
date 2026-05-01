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
            //Location = new Point(2, 2),
            Height = 30,
            //MinimumSize = new Size(30, 30),
            AutoEllipsis = true,
            ForeColor = Color.White,
            BackColor = Color.Black,
            Text = labelText,
            Margin = new Padding(0, 0, 0, 2),
            
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
        };


        downloadsTableLayoutPanel.Controls.Add(label);
        //flowLayoutPanelDownloads.Controls.Add(label);
        label.BringToFront();

        // Set button appearance for different states
        Action downloadStarted = () => { label.BackColor = Color.DarkGoldenrod; };
        Action downloadCancelled = () => { label.BackColor = Color.DarkGray; };
        Action downloadCompleted = () => { label.BackColor = Color.DarkGreen; };
        Action downloadFailed = () => { label.BackColor = Color.DarkRed; };
        Action disposeLabel = () => { label.Dispose(); };

        // Return a set of actions denoting the different download states represented by the label
        return new Utilities.DownloadActions(downloadStarted, downloadCancelled, downloadCompleted, downloadFailed, disposeLabel);

    }

    private async void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
    {
        string linkText = textBoxLink.Text;
        string targetFile = textBoxTarget.Text;

        if (!Utilities.Downloader.ValidLink(linkText) || !Utilities.Downloader.ValidFilePath(targetFile))
        {
            MessageBox.Show("Both web address and file path must be given to add download.");
        }
        else
        {
            Utilities.DownloadActions actions = AddDownloadLabel(linkText);

            // Queue the downloads
            Utilities.DownloadHandler.AddDownload(linkText, targetFile, actions);

            // Clear text
            textBoxLink.Text = null;
            textBoxTarget.Text = null;

            // Start automatically if check box is checked
            if (checkBoxAutoStart.Checked)
            {
                Utilities.DownloadHandler.StartDownload();
            }
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
    private void clearDoneButton_MouseClick(object sender, MouseEventArgs e)
    {
        Utilities.DownloadHandler.Dispose();
    }
}
