using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9._0.Models;

namespace Tarea9._0.DAO
{
    public class PersonaDAO
    {
        private readonly ApplicationDbContext db;

        public PersonaDAO(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<PersonaModel>> GetPersonas()
        {
            return await db.Personas.ToListAsync();
        }
        public async Task<PersonaModel> GetPersonaDetails(int id)
        {
            var persona = await db.Personas.FindAsync(id);

            return persona;
        }
        public async Task<bool> RegistrarPersona(PersonaModel persona)
        {
            db.Personas.Add(persona);

            return await db.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdatePersona(PersonaModel persona)
        {
            db.Entry(persona).State = EntityState.Modified;

            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeletePersona(int id)
        {
            var persona = await db.Personas.FindAsync(id);
            db.Personas.Remove(persona);

            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> SavePersona(PersonaModel persona)
        {
            var resultado = await db.Personas.FirstOrDefaultAsync(o => o.Cedula.Equals(persona.Cedula));

            if (resultado == null)
            {
                return await RegistrarPersona(persona);
            }
            else
                return false;
        }
    }
}
