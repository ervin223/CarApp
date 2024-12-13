using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace CarApp.ApplicationServices
{
    public class FileServices : IFileServices
    {
        private readonly string _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

        public FileServices()
        {
            if (!Directory.Exists(_uploadFolder))
            {
                Directory.CreateDirectory(_uploadFolder);
            }
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(_uploadFolder, file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filePath;
        }

        public bool FileExists(string fileName)
        {
            var filePath = Path.Combine(_uploadFolder, fileName);
            return File.Exists(filePath);
        }
    }
}
