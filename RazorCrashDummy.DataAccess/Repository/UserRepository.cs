using RazorCrashDummy.DataAccess.Data;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using RazorCrashDummy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCrashDummy.DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(User user)
        {
            var objFromDb = _db.User.FirstOrDefault(u => u.Id == user.Id);
            objFromDb.Name = user.Name;
            objFromDb.LastName = user.LastName;
            objFromDb.Username = user.Username;
            objFromDb.Password = user.Password;
            objFromDb.Active = user.Active;
        }
    }
}
