using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public interface IAppointment<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Add(T t);
        bool Delete(T t);
    }
}