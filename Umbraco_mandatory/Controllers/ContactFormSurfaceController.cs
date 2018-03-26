using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco_mandatory.ViewModels;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace Umbraco_mandatory.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }
    }
}