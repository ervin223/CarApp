using Microsoft.AspNetCore.Http;

namespace CarApp.Core.ServiceInterface
{
    public interface IFileServices
    {
        string UploadFile(IFormFile file);
    }
}
