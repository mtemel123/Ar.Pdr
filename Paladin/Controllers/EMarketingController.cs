using Ar.Present.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ar.Inf.Common;
using Ar.Inf.Filter;
using Ar.Model;

namespace Ar.Present.Controllers
{
    [HttpAuthenticate("EAdmin", "Testing123")]
    public class EMarketingController : Controller
    {
        private PaladinDbContext _context;
        
        public EMarketingController(PaladinDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult WeeklyReport(EWeeklyReport weeklyReport)
        {
            if (ModelState.IsValid)
            {
                _context.WeeklyReports.AddOrUpdate(weeklyReport);
                _context.SaveChanges();
                return Content("Success");
            }

            return Content("Error");
        }

        [HttpPost]
        public ActionResult MonthlyReport(EMonthlyReport monthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.MonthlyReports.Add(monthlyReport);
                _context.SaveChanges();
                return Content("Success");
            }

            return Content("Error");
        }
    }
}