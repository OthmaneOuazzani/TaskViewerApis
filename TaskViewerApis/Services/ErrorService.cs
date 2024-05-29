using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Dtos;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Services
{
    public class ErrorService : IErrorService
    {
        private readonly TaskViewerApis.Data.Context _context;
        private readonly IMapper _mapper;


        public ErrorService(TaskViewerApis.Data.Context context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Error> createError(Error error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error), "Error object is null");
            }

            if (string.IsNullOrEmpty(error.PlmId))
            {
                error.PlmId = GenerateNewErrorPlmId();
            }

            _context.Errors.Add(error);
            await _context.SaveChangesAsync();

            return error;
        }

     

        public string  GenerateNewErrorPlmId()
        {
            var plmIds = _context.Errors.Select(e => e.PlmId).ToList();

            var numbers = plmIds
                .Select(plmId => plmId.Replace("BOM", ""))
                .Select(numString => int.TryParse(numString, out int num) ? num : 0);

            var maxNumber = numbers.Any() ? numbers.Max() : 0;
            var newNumber = maxNumber + 1;

            return $"BOM{newNumber}";
        }

        public async Task<Error> getError(string id)
        {
            return await _context.Errors.FirstOrDefaultAsync(e => e.PlmId == id);
        }

        public async Task<IEnumerable<Error>> getErrors()
        {
            return await _context.Errors.ToListAsync();
        }

        public async Task<Error> updateError(string id, Error error)
        {
            var existingError = await _context.Errors.FirstOrDefaultAsync(e => e.PlmId == id);
            if (existingError == null)
            {
                return null; 
            }
            _mapper.Map(error, existingError);

            _context.Errors.Update(existingError); 
            await _context.SaveChangesAsync();

            return existingError;
        }
        public async Task<bool> deleteError(string id)
        {
            var existingError = await _context.Errors.FirstOrDefaultAsync(e => e.PlmId == id);
            if (existingError == null)
            {
                return false;
            }
            _context.Errors.Remove(existingError);
            await _context.SaveChangesAsync();

            return true; 
        }


    }
}
