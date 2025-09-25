using NZWalks.API.Models.Domains;

namespace NZWalks.API.Repositories.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}