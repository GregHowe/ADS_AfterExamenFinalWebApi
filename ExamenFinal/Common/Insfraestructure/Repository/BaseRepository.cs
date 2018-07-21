using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        DbSet<T> _dbSet;

        protected readonly DbEstudiantesContext _context;

        public BaseRepository(DbEstudiantesContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            var result = new List<T>();
            return result; 
        }
    }
}
