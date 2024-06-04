using TaskViewerApis.Models;

namespace TaskViewerApis.Interfaces
{
    public interface IRatingService
    {
        Task<Rating> saveRating(Rating rating);
    }
}