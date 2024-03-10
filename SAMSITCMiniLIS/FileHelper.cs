namespace SAMSITCMiniLIS
{
    public class FileHelper
    {
        public static string REPORT_TEMPLATE_PATH = "report_templates";

        public static string[] GetReportNames()
        {
            string[] filePaths= Directory.GetFiles(REPORT_TEMPLATE_PATH);
            List<string> fileNames = new List<string>();
            foreach (string file in filePaths)
            {
                fileNames.Add(Path.GetFileNameWithoutExtension(file));
            }
            return fileNames.ToArray();
        }
    }
}
