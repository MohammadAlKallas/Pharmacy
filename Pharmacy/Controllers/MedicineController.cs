using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Pharmacy.Interface;
using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class MedicineController : Controller
    {
        private readonly MedicineInterface medicineRepository;
        public MedicineController(MedicineInterface _medicineRepository)
        {
            this.medicineRepository = _medicineRepository;
        }
        public async Task<IActionResult> ShowMedicine()
        {
            return View(await medicineRepository.GetMedicines());
        }

        /********** Create New Medicine ************/
        [HttpGet]
        public async Task<IActionResult> CreateMedicine()
        {
            /********** Fill Dropdownlist in the interface ************/
            ViewBag.CompanyList = new SelectList(await medicineRepository.GetCompanies(), "Id", "Value");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedicine(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                 await medicineRepository.AddMedicine(medicine);
                return RedirectToAction("ShowMedicine");
            }

            /********** Fill Dropdownlist in the interface ************/
            ViewBag.CompanyList = new SelectList(await medicineRepository.GetCompanies(), "Id", "Value");
            return View(medicine);
        }

        /********** Edit Product ************/
        [HttpGet]
        public async Task<IActionResult> UpdateMedicine(int ID)
        {
            /********** Fill Dropdownlist in the interface ************/
            ViewBag.CompanyList = new SelectList(await medicineRepository.GetCompanies(), "Id", "Value");

            return View(await medicineRepository.GetMedicine(ID));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMedicine(Medicine medicine)
        {
            await medicineRepository.UpdateMedicine(medicine);
            return RedirectToAction("ShowMedicine");
        }

        /********** Delete Medicine ************/
        public async Task<IActionResult> DeleteMedicine(int ID)
        {
            await medicineRepository.DeleteMedicine(ID);
            return RedirectToAction("ShowMedicine");
        }

       
    }
}
