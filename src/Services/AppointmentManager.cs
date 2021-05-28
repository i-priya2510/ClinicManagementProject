
using ClinicManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public class AppointmentManager : IAppointment<Appointments>
    {
        private ClinicContext _context;
        private ILogger<AppointmentManager> _logger;
        public AppointmentManager(ClinicContext context, ILogger<AppointmentManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public bool Add(Appointments t)
        {
            try
            {
                _context.Appointments.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return false;
            }
        }
        public IEnumerable<Appointments> GetAll()
        {
            try
            {
                if (_context.Appointments.Count() == 0)
                    return null;
                return _context.Appointments.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public bool Delete(Appointments t)
        {
            try
            {
                _context.Appointments.Remove(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return false;
            }
        }

        public Appointments Get(int id)
        {
            try
            {
                Appointments author = _context.Appointments.FirstOrDefault(a => a.Appointment_Id == id);
                return author;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}
