using AutomaticFileDownloader.Utilities.Handlers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomaticFileDownloader;

public partial class AutoDownloaderForm : Form
{
    // Define handler for managing downloads
    private static Utilities.Handlers.DownloadHandler _handler = new Utilities.Handlers.DownloadHandler();

    public AutoDownloaderForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Helper method to add a label for a given download operation
    /// </summary>
    /// <param name="labelText">label of text</param>
    /// <returns></returns>
    private OperationEvents AddDownloadLabel(string labelText)
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
        EventHandler downloadStarted = (sender, args) => { label.BackColor = Color.DarkGoldenrod; };
        EventHandler downloadCancelled = (sender, args) => { label.BackColor = Color.DarkGray; };
        EventHandler downloadCompleted = (sender, args) => { label.BackColor = Color.DarkGreen; };
        EventHandler downloadFailed = (sender, args) => { label.BackColor = Color.DarkRed; };
        EventHandler disposeLabel = (sender, args) => { label.Dispose(); };

        // Return a set of actions denoting the different download states represented by the label
        return new Utilities.Handlers.OperationEvents(downloadStarted, downloadCancelled, downloadCompleted, downloadFailed, disposeLabel);
    }

    /// <summary>
    /// Adds download to the queue
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
            Utilities.Handlers.OperationEvents events = AddDownloadLabel(linkText);
            Utilities.Handlers.DownloadArguments args = new Utilities.Handlers.DownloadArguments(linkText, targetFile);

            // Queue the downloads
            _handler.QueueOperation(events, args);

            // Clear text
            textBoxLink.Text = null;
            textBoxTarget.Text = null;

            // Start automatically if check box is checked
            if (checkBoxAutoStart.Checked)
            {
                _handler.Start();
            }
        }
    }

    /// <summary>
    /// Sets download intended file path
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSetTarget_MouseClick(object sender, MouseEventArgs e)
    {
        if (fileSaveDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxTarget.Text = fileSaveDialog.FileName;
        }
    }

    /// <summary>
    /// Start downloads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonStart_MouseClick(object sender, MouseEventArgs e)
    {
        _handler.Start();
    }

    /// <summary>
    /// Cancel downloads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ButtonCancel_MouseClick(object sender, MouseEventArgs e)
    {
        _handler.Cancel();
    }

    /// <summary>
    /// Clear downloads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clearDoneButton_MouseClick(object sender, MouseEventArgs e)
    {
        _handler.Clear();
    }

    
}
