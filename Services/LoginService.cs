using Genesys_Core_API.DTO.UserDto;
using Genesys_Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Genesys_Core_API.Services
{
    public class LoginService
    {
        private readonly ApplicationDbContext _dbcontext;
        public LoginService(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<User?> GetUser (UserDto user)
        {
            return await _dbcontext.Users.SingleOrDefaultAsync(usr => usr.UserName == user.UserName &&
            usr.Password == user.Password); 
        }

    }
}
