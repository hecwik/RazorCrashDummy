using RazorCrashDummy.DataAccess.Data;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCrashDummy.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            User = new UserRepository(_db);
            Location = new LocationRepository(_db);
            Shift = new ShiftRepository(_db);
        }

        public IUserRepository User { get; private set; }
        public ILocationRepository Location { get; set; }
        public IShiftRepository Shift { get; set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
