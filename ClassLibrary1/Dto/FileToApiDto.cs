namespace CarApp.ApplicationServices
{
    public class FileToApiDto
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public FileToApiDto(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
