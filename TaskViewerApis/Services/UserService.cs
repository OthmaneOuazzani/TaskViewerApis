using Newtonsoft.Json;
using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;

namespace TaskViewerApis.Services
{
    public class UserService : IUserService
    {
        private readonly TaskViewerApis.Data.Context _context;

        private readonly IMapper _mapper;


        public UserService(TaskViewerApis.Data.Context context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> getUser(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PlmId == id);
        }

        public async Task<IEnumerable<User>> getUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> getUsersByProject(string projectId)
        {
            var usersByProject = _context.Users.Where(u =>
                u.Proj1 == projectId ||
                u.Proj2 == projectId ||
                u.Proj3 == projectId ||
                u.Proj4 == projectId ||
                u.Proj5 == projectId ||
                u.Proj6 == projectId ||
                u.Proj7 == projectId ||
                u.Proj8 == projectId ||
                u.Proj9 == projectId ||
                u.Proj10 == projectId);

            return await usersByProject.ToListAsync();
        }

        public async Task<IEnumerable<User>> getColleagues(string userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PlmId == userId);
            var colleagues = _context.Users.Where(u =>
                u.Proj1 == user.Proj1 ||
                u.Proj2 == user.Proj2 ||
                u.Proj3 == user.Proj3 ||
                u.Proj4 == user.Proj4 ||
                u.Proj5 == user.Proj5 ||
                u.Proj6 == user.Proj6 ||
                u.Proj7 == user.Proj7 ||
                u.Proj8 == user.Proj8 ||
                u.Proj9 == user.Proj9 ||
                u.Proj10 == user.Proj10);

            return await colleagues.ToListAsync();
        }

        public async Task<User> updateUser(User user, string id)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.PlmId == id);

            if (existingUser == null)
            {
                return null;
            }

            _mapper.Map(user, existingUser);

            await _context.SaveChangesAsync();

            return existingUser;
        }
    }
}

//public UserService(TaskViewerApis.Data.Context context)
//{
//    _context = context;
//    users = _context.Users.ToListAsync().GetAwaiter().GetResult();
//    //LoadUsersAsync().GetAwaiter().GetResult();
//}


//private async Task LoadUsersAsync()
//{
//    string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_USER_DATA_TABLE.json";
//    string jsonData = await File.ReadAllTextAsync(filePath);
//    var users = JsonConvert.DeserializeObject<IEnumerable<User>>(jsonData,new BoolConverter() ,new DateConverter()) ?? Enumerable.Empty<User>();

//    foreach (var user in users)
//    {
//        // Clear the context's change tracker
//        _context.ChangeTracker.Clear();


//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//    }
//}


