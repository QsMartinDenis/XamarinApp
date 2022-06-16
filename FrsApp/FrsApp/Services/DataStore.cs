using FrsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrsApp.Services
{
    public class DataStore : IDataStore<User>
    {
        private readonly List<User> users = new List<User>();

        public async Task<bool> AddUserAsync(User user)
        {
            users.Add(user);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<User>> GetUsersAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(users);
        }
    }
}
