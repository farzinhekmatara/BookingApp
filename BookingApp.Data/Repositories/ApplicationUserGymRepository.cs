﻿using BookingApp.Core.Entitis;
using BookingApp.Core.Repositories;
using BookingApp.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Repositories
{
    public class ApplicationUserGymRepository : IApplicationUserGymRepository
    {
        private readonly ApplicationDbContext db = null!;

        public ApplicationUserGymRepository(ApplicationDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        [return: MaybeNull]
        public async Task<ApplicationUserGymClass?> FindAsync(string userId, int gymClassId)
        {
            return await db.AppUserGyms.FindAsync(userId, gymClassId);
        }

        public void Add(ApplicationUserGymClass booking)
        {
            db.AppUserGyms.Add(booking);
        }

        public void Remove(ApplicationUserGymClass attending)
        {
            db.Remove(attending);
        }


    }
}
