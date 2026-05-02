namespace AutomaticFileDownloader.Utilities.Handlers
{
    /// <summary>
    /// Record storing arguments of download
    /// 
    /// Records can apparently be abstract and can be inherited https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record#inheritance
    /// </summary>
    /// <param name="URL"> Url downloaded from </param>
    /// <param name="TargetFilePath"> path for download to go </param>
    public record DownloadArguments(string URL, string TargetFilePath) : OperationArguments();
}