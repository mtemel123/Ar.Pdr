using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ar.Inf.Result;
using Ar.Model;
using Ar.Model.ViewModels;

namespace Ar.Present.Controllers
{
    public class ServiceController : Controller
    {
        private PaladinDbContext _context;

        public ServiceController()
        {
            _context = new PaladinDbContext();
        }

        public ActionResult GetApplicantsForReminders()
        {
            var applicants = _context.Applicants.ToList();
            var vmApplicants = new List<ApplicantVM>();
            foreach(var app in applicants)
            {
                vmApplicants.Add(Mapper.Map<ApplicantVM>(app));
            }

            return new XMLResult(vmApplicants);
        }

    }
}