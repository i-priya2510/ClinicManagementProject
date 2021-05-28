using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public interface IUser<T>
    {
        T Get(int id);
        bool Update(T t);
    }
}