using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novena.IRepository
{
    public interface IRepository<T> where T : class
    {
        DataTable GetAll();
        void Add(T ado);
        void Update(T ado, int id);
        void Delete(int id);
    }
}
