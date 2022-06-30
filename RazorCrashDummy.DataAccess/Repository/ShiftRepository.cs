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
    public class ShiftRepository : Repository<Shift>, IShiftRepository
    {
        private readonly ApplicationDbContext _db;
        public ShiftRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Shift obj)
        {
            var objFromDb = _db.Shift.FirstOrDefault(u => u.Id == obj.Id);
            objFromDb.StartTime = obj.StartTime;
            objFromDb.EndTime = obj.EndTime;
            objFromDb.UserId = obj.UserId;
            objFromDb.LocationId = obj.LocationId;
        }
    }
}
