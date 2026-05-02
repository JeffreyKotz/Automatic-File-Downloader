namespace AutomaticFileDownloader.Utilities.Handlers
{
    // Record storing arguments of download
    // Records can apparently be abstract and can be inherited https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record#inheritance
    public record DownloadArguments(string URL, string TargetFilePath) : OperationArguments();
}