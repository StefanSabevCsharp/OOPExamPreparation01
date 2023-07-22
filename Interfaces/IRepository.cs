using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Interfaces
{
    public interface IRepository<T>
    {
        void AddModel(T user);
        bool RemoveById(string identifier);
        T FindById(string identifier);
        IReadOnlyCollection<T> GetAll();

    }
}
