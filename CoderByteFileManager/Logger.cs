namespace CoderByteFileManager
{
    public class Logger
    {
        /// <summary>
        /// Responsible for log activity messages to a text file named "activity_log.txt". Each log entry should be timestamped and followed by a specific message. For instance, a log entry might look like this: `[2023-12-06 10:00:00]: Organizing and Analysis completed`.
        /// </summary>
        public void LogActivity(string message)
        {
            string logFilePath = "activity_log.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    string logEntry = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]: {message}";
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log activity: {ex.Message}");
            }
        }
    }
}