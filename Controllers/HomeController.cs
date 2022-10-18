using RecordingOfViolations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecordingOfViolations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ViolationContext _context;

        public HomeController(ViolationContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View(_context.Violations);
        }
        
        [HttpGet]
        public ActionResult Pay(int id)
        {
            ViewBag.ViolationId = id;
            return View();
        }

        [HttpPost]
        public string Pay(PaymentСheck paymentСheck)
        {
            _context.Add(paymentСheck);
            _context.SaveChanges();
            return $"Дякую, {paymentСheck.Payer}, за оплату!";
        }

        [HttpGet]
        public ActionResult EditViolation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Violation violation = _context.Violations.FirstOrDefault(v => v.ViolationId == id);

            if(violation is not null)
            {
                return View(violation);
            }
            return NotFound();
        }
         
        [HttpPost]
        public ActionResult EditViolation(Violation violation)
        {
            _context.Entry(violation).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateViolation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateViolation(Violation violation)
        {
            _context.Violations.Add(violation);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteViolation(int id)
        {
            Violation violation = _context.Violations.FirstOrDefault(p => p.ViolationId == id);

            if (violation is null)
            {
                return NotFound();
            }

            return View(violation);
        }

        [HttpPost,ActionName("DeleteViolation")]
        public ActionResult DeleteConfirmed(int id)
        {
            Violation violation = _context.Violations.FirstOrDefault(p => p.ViolationId == id);

            if (violation is null)
            {
                return NotFound();
            }

            _context.Violations.Remove(violation);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}