
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharmacy.Interface;
using Pharmacy.Models;
using Pharmacy.Repostories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Controllers
{
    public class HomeController : Controller
    {
        private readonly MedicineInterface medicineRepository;
        public HomeController(MedicineInterface _medicineRepository)
        {
            this.medicineRepository = _medicineRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await medicineRepository.GetMedicines());
        }

        public async Task<IActionResult> MedicineDetails(int ID)
        {
            return View(await medicineRepository.GetMedicine(ID));
        }

        public async Task<IActionResult> MedicineSearch(string value)
        {

            /********** Product Search BY Title OR Description ************/
            if (!string.IsNullOrEmpty(value))
            {
                return View(await medicineRepository.SearchMedicine(value));
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
