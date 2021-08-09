using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Models;

namespace Tarea9._0.DAO
{
    public class ProvinciaDAO
    {
        private readonly ApplicationDbContext db;

        public ProvinciaDAO(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Provincia>> GetProvincia()
        {
            return await db.Provincias.ToListAsync();
        }
        public async Task<Provincia> GetProvinciaDetails(int id)
        {
            var provincia = await db.Provincias.FindAsync(id);

            //if (persona == null)
            //{
            //    return null;
            //}

            return provincia;
        }
        public async Task<bool> RegistrarProvincia(Provincia provincia)
        {
            db.Provincias.Add(provincia);

            return await db.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateProvincia(Provincia provincia)
        {
            db.Entry(provincia).State = EntityState.Modified;

            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteProvincia(int id)
        {
            var provincia = await db.Provincias.FindAsync(id);
            db.Provincias.Remove(provincia);

            return await db.SaveChangesAsync() > 0;
        }
    }
}
