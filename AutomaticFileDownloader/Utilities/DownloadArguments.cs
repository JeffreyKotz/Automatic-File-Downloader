using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{
    internal class DownloadArguments : OperationArguments
    {
        public string Url { get; set; }
        public string TargetFilePath { get; set; }
    }
}
