using System.Linq.Expressions;

namespace Fourth;

public class FileExporter
{
    CompressFile compress = new();
    ExportData export = new();
    SendFileToFTP send = new();

    public void Handler(string filePath, List<string> data)
    {
        compress.CompressFileMethod(filePath);

        send.SendFileToFTPMethod(filePath);

        export.ExportDataMethod(data);
    }
}