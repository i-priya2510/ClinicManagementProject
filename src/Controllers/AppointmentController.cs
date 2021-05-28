
using ClinicManagementProject.Models;
using ClinicManagementProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Controllers
{
    public class AppointmentController : Controller
    {
        private ClinicContext _context;
        private ILogger<AppointmentController> _logger;
        private IAppointment<Appointments> _repo;
        public AppointmentController(ClinicContext context,IAppointment<Appointments> repo, ILogger<AppointmentController> logger)
        {
            _context = context;
            _logger = logger;
            _repo = repo;
        }
        public IActionResult Index()
        {
            List<Appointments> appointments = _repo.GetAll().ToList();
            return View(appointments);
        }
        public IActionResult AddPointment()
        {
            
            return View();
            
        }
        [HttpPost]
        [HttpGet]
        public IActionResult AddPointment(Appointments appointment)
        {
            try
            {
                var docs = _context.Doctors.ToList();
                ViewBag.items = docs.Select(i => i.FirstName).ToList();
                if (_repo.Add(appointment))
                {
                    ViewBag.addapp = "Appointment Recorded";
                }
                else
                {
                    ViewBag.addapp = "Sorry couldn't add the record try again";
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        public IActionResult DeleteAppointment(int id)
        {
            Appointments appointment = _repo.Get(id);
            return View(appointment);
        }
        [HttpPost]
        public IActionResult DeleteAppointment(Appointments appointment)
        {
            try
            {
                if (_repo.Delete(appointment))
                {
                    ViewBag.delapp = "Record deleted";
                }
                else
                {
                    ViewBag.delapp = "Sorry couldn't add the record try again";
                }
            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}