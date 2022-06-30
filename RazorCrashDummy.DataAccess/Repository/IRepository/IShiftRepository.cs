﻿using RazorCrashDummy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCrashDummy.DataAccess.Repository.IRepository
{
    public interface IShiftRepository : IRepository<Shift>
    {
        void Update(Shift shift);
    }
}
