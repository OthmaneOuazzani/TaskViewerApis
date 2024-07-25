using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Services
{
    public class LaService : ILaService
    {
        private readonly TaskViewerApis.Data.Context _context;
    

        public LaService(TaskViewerApis.Data.Context context)
        {
            _context = context;
       
        }

        public async Task<IEnumerable<La>> GetAllLas()
        {
            return await _context.Las.ToListAsync();
        }

        public async Task<La> GetLa(string plmId)
        {
            return await _context.Las.FirstOrDefaultAsync(l => l.PlmId == plmId);
        }


        public async Task<PaginatedResponse<La>> GetLaPage(int page, int pageSize)
        {
            int totalCount = await _context.Las.CountAsync();
            List<La> items = await _context.Las
                                         .Skip((page - 1) * pageSize)
                                         .Take(pageSize)
                                         .ToListAsync();

            return new PaginatedResponse<La>
            {
                Items = items,
                TotalCount = totalCount
            };
        }
    }
}
