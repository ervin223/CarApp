using System.Collections.Generic;

namespace CarApp.ApplicationServices
{
    public class FileToApi
    {
        public List<string> Files { get; set; }

        public FileToApi(List<string> files)
        {
            Files = files;
        }
    }
}
