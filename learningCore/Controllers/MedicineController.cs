using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learningCore.Models;
using learningCore.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace learningCore.Controllers
{
    [Route("[controller]/[action]")]
    public class MedicineController : Controller
    {
        private readonly IMedicineRepos _medicineRepos;
       
        public MedicineController(IMedicineRepos medicineRepos)
        {
            _medicineRepos = medicineRepos;
        }

        [Route("~/Medicine")]
        [Route("/")]
        public ViewResult Index()
        {
            IEnumerable<Medicines> model = _medicineRepos.GetAllMedicines();
            return View(model);
        }
        
        
    }
}
