using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public interface IHome<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Add(T t);
    }
}