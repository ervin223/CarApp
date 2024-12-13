using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CarApp.Core.Interfaces
{
    public interface IFileServices
    {
        Task<string> SaveFileAsync(IFormFile file);
        bool FileExists(string fileName);
    }
}
