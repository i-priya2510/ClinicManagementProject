using ClinicManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Services
{
    public class HomeManager : IHome<Doctors>,IHome<Patients>
    {
        private ClinicContext _context;
        private ILogger<HomeManager> _logger;
        public HomeManager(ClinicContext context, ILogger<HomeManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Add(Doctors t)
        {
            try
            {
                _context.Doctors.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return false;
            }
        }

        public bool Add(Patients t)
        {
            try
            {
                _context.Patients.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return false;
            }
        }

        public Doctors Get(int id)
        {
            try
            {
                Doctors doctor = _context.Doctors.FirstOrDefault(a => a.Doctor_Id == id);
                return doctor;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<Doctors> GetAll()
        {
            try
            {
                if (_context.Doctors.Count() == 0)
                    return null;
                return _context.Doctors.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        Patients IHome<Patients>.Get(int id)
        {
            try
            {
                Patients patient = _context.Patients.FirstOrDefault(a => a.Patient_Id == id);
                return patient;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        IEnumerable<Patients> IHome<Patients>.GetAll()
        {
            try
            {
                if (_context.Patients.Count() == 0)
                    return null;
                return _context.Patients.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}