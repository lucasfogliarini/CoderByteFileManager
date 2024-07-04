using CoderByteFileManager;

string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string coderByteFileManagerPath = Path.Combine(desktopPath, "CoderByteFileManagerFolders");
string sourceDirectory = Path.Combine(coderByteFileManagerPath, "SourceFolder");
string destinationDirectory = Path.Combine(coderByteFileManagerPath, "DestinationFolder");

FileOrganizer organizer = new();
FileAnalyzer analyzer = new();
Logger logger = new();

logger.LogActivity("Organizing the files.");
organizer.OrganizeFiles(sourceDirectory, destinationDirectory);

logger.LogActivity("Analyzing the files.");
Dictionary<string, int> extensionCounts = analyzer.AnalyzeExtensions(destinationDirectory);

logger.LogActivity("Organizing and Analysis completed.");

Console.WriteLine("Extension Counts:");
foreach (var kvp in extensionCounts)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}