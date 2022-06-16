using FrsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrsApp.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddUserAsync(User user);
        Task<IEnumerable<User>> GetUsersAsync(bool forceRefresh = false);
    }
}
