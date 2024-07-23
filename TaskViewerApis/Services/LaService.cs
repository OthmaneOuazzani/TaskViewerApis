using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Services
{
    public class LaService : ILaService
    {
        private readonly TaskViewerApis.Data.Context _context;
        private readonly IEnumerable<La> las;

        public LaService(TaskViewerApis.Data.Context context)
        {
            _context = context;
            las = _context.Las.ToList();
        }

        public async Task<IEnumerable<La>> GetAllLas()
        {
            return await Task.FromResult(las);
        }

        public async Task<La> GetLa(string plmId)
        {
            return await _context.Las.FirstOrDefaultAsync(l => l.PlmId == plmId);
        }

        public async Task<IEnumerable<La>> GetLaPage(int page = 1 , int pageSize =15)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, await _context.Las.CountAsync());
            List<La> las = await _context.Las.Skip(startIndex).Take(endIndex - startIndex).ToListAsync();

            return las;
        }   
    }
}
