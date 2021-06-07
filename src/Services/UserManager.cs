using ClinicManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public class UserManager : IUser<Users>
    {
        private ClinicContext _context;
        private ILogger<UserManager> _logger;
        public UserManager(ClinicContext context, ILogger<UserManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Users Get(int id)
        {
            try
            {
                Users User = _context.Users.FirstOrDefault(a => a.Id == id);
                return User;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public bool Update(Users t)
        {
            var data = _context.Users.Where(s => s.UserName.Equals(t.UserName) && s.Password.Equals(t.Password)).ToList();
            if (data.Count()>0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
