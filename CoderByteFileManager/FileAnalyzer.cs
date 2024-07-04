namespace CoderByteFileManager
{
    public class FileAnalyzer
    {
        /// <summary>
        /// Responsible for return a dictionary where keys are file extensions and values are counts of how many files have that extension in the specified directory.
        /// </summary>
        public Dictionary<string, int> AnalyzeExtensions(string directory)
        {
            Dictionary<string, int> extensionCounts = new Dictionary<string, int>();

            if (!Directory.Exists(directory))
            {
                var message = "Directory does not exist.";
                throw new Exception(message);
            }

            string[] files = Directory.GetFiles(directory);

            Console.WriteLine($"Files number: {files.Length}");

            foreach (string filePath in files)
            {
                string extension = Path.GetExtension(filePath).TrimStart('.').ToLower();

                if (extensionCounts.ContainsKey(extension))
                {
                    extensionCounts[extension]++;
                }
                else
                {
                    extensionCounts[extension] = 1;
                }
            }

            return extensionCounts;
        }
    }
}