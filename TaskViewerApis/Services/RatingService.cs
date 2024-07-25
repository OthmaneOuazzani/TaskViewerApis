
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskViewerApis.Services
{
    public class RatingService : IRatingService

    {
        private readonly TaskViewerApis.Data.Context _context;

        public RatingService(TaskViewerApis.Data.Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rating>> getRatings()
        {
            {
                return await _context.Ratings.ToListAsync();
            }
        }

        public async Task<Rating> saveRating(Rating rating)
        {
            {
                if (rating == null)
                {
                    throw new ArgumentNullException(nameof(rating), "Rating object is null");
                }

                _context.Ratings.Add(rating);
                await _context.SaveChangesAsync();

                return rating;


            }
        }
    }
}
