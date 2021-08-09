using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Models;

namespace Tarea9._0.DAO
{
    public class SangreDAO
    {
        private readonly ApplicationDbContext db;

        public SangreDAO(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<SangreModel>> GetSangres()
        {
            return await db.Sangres.ToListAsync();
        }
        public async Task<SangreModel> GetSangreDetails(int id)
        {
            var sangre = await db.Sangres.FindAsync(id);

            return sangre;
        }
        public async Task<bool> RegistrarSangre(SangreModel sangre)
        {
            db.Sangres.Add(sangre);

            return await db.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateSangre(SangreModel sangre)
        {
            db.Entry(sangre).State = EntityState.Modified;

            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteSangre(int id)
        {
            var sangre = await db.Sangres.FindAsync(id);
            db.Sangres.Remove(sangre);

            return await db.SaveChangesAsync() > 0;
        }
        public async Task<bool> SaveSangre(SangreModel sangre)
        {
            if (sangre.Id > 0)
                return await UpdateSangre(sangre);
            else
                return await RegistrarSangre(sangre);
        }
    }
}
