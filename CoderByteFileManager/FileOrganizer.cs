namespace CoderByteFileManager
{
    public class FileOrganizer
    {
        /// <summary>
        /// Responsible for move files from the source directory to the destination directory.
        /// 
        /// Files should be organized into subfolders in the destination directory based on their extension (e.g., "jpg" files go into a "jpg" folder)
        /// </summary>
        public void OrganizeFiles(string sourceDirectory, string destinationDirectory)
        {
            Directory.CreateDirectory(sourceDirectory);

            Directory.CreateDirectory(destinationDirectory);

            string[] filesInSourceDirectory = Directory.GetFiles(sourceDirectory);
            Console.WriteLine($"{filesInSourceDirectory.Length} files in the '{sourceDirectory}'");

            string[] filesInDestinationDirectory = Directory.GetFiles(sourceDirectory);
            Console.WriteLine($"{filesInDestinationDirectory.Length} files in the '{destinationDirectory}'");

            Console.WriteLine();

            foreach (string filePath in filesInSourceDirectory)
            {
                Directory.CreateDirectory(destinationDirectory);

                string fileName = Path.GetFileName(filePath);
                string destFilePath = Path.Combine(destinationDirectory, fileName);

                if (!File.Exists(destFilePath))
                {
                    File.Move(filePath, destFilePath);
                    Console.WriteLine($"The file {filePath} was moved to {destFilePath}.");
                }
                else
                {
                    Console.WriteLine($"File '{fileName}' already exists in destination folder.");
                }
            }

            Console.WriteLine("File organization completed.");
        }
    }
}