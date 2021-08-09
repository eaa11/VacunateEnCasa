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

        public async Task<IEnumerable<Persona>> GetPersonas()
        {
            return await db.Personas.ToListAsync();
        }
        public async Task<Persona> GetPersonaDetails(int id)
        {
            var persona = await db.Personas.FindAsync(id);

            return persona;
        }
        public async Task<bool> RegistrarPersona(Persona persona)
        {
            db.Personas.Add(persona);

            return await db.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdatePersona(Persona persona)
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

        public async Task<bool> SavePersona(Persona persona)
        {
            if (persona.Id > 0)
                return await UpdatePersona(persona);
            else
                return await RegistrarPersona(persona);
        }
    }
}
