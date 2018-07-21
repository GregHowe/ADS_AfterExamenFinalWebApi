using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    public interface IBaseRepository<T> where T: class
    {
        List<T> GetAll();
    }
}
