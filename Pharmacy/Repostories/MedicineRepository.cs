using Newtonsoft.Json;
using Pharmacy.Interface;
using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Repostories
{
    public class MedicineRepository : MedicineInterface
    {
        private readonly HttpRequestInterface httpRequestInterface;
        public MedicineRepository(HttpRequestInterface httpRequestInterface)
        {
            this.httpRequestInterface = httpRequestInterface;
        }
        public async Task<Medicine> GetMedicine(int medicineId)
        {
            var Result =await httpRequestInterface.getJson("Home/GetMedicineDetails/" + medicineId);
            return JsonConvert.DeserializeObject<Medicine>(Result.ToString());
        }

        public async Task<IEnumerable<Medicine>> GetMedicines()
        {
            var Result = await httpRequestInterface.getJson("Home/GetMedicines");
            if(Result!=null)
            return JsonConvert.DeserializeObject<IEnumerable<Medicine>>(Result.ToString());
            return null;
        }

        public async Task<IEnumerable<Medicine>> SearchMedicine(string Value)
        {
            var Result = await httpRequestInterface.getJson("Home/MedicineSearch/" + Value);
            return JsonConvert.DeserializeObject<IEnumerable<Medicine>>(Result.ToString());
        }

        public async Task<string> DeleteMedicine(int medicineId)
        {
            var Result = await httpRequestInterface.DeleteJson("Home/MedicineDelete/" + medicineId);
            return null;
        }
        public async Task<object> AddMedicine(Medicine medicine)
        {
            var Result = await httpRequestInterface.PostJson("Home/CreateMedicine", medicine);
            return Result;
        }
        public async Task<object> UpdateMedicine(Medicine medicine)
        {
            var Result = await httpRequestInterface.PutJson("Home/MedicineUpdate", medicine);
            return Result;
        }
        public async Task<IEnumerable<ManufactureCompany>> GetCompanies()
        {
            var Result = await httpRequestInterface.getJson("Home/GetCompanies");
            return JsonConvert.DeserializeObject<IEnumerable<ManufactureCompany>>(Result.ToString());
        }



        public Task<ManufactureCompany> AddCompany(ManufactureCompany company)
        {
            throw new NotImplementedException();
        }
        public Task<ManufactureCompany> GetCompany(int companyId)
        {
            throw new NotImplementedException();
        }
        public Task<ManufactureCompany> UpdateCompany(ManufactureCompany company)
        {
            throw new NotImplementedException();
        }
        public Task<ManufactureCompany> DeleteCompany(int companyId)
        {
            throw new NotImplementedException();
        }

       
    }
}
