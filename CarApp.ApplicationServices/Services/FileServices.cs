using Microsoft.AspNetCore.Http;
using CarApp.Core.ServiceInterface;
using CarApp.Core.ServiceInterfaces;

namespace CarApp.ApplicationServices.Services
{
    public class FileServices : IFileServices
    {
        public string UploadFile(IFormFile file)
        {
            var filePath = Path.Combine("uploads", file.FileName);
            using var stream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(stream);
            return filePath;
        }
    }
}
