using Fourth;

FileExporter exporter = new();

string filePath = "C/User/Desktop/HomeTask";

List<string> data = new()
{
    "New info",
    "New info",
    "New info"
};

exporter.Handler(filePath, data);