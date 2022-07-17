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
    public class HttpRepository : HttpRequestInterface
    {

        public async Task<object> getJson(string Uri)
        {
            try
            {
                string Url = "http://localhost:27129/api/" + Uri;
                var client = new HttpClient();
                client.BaseAddress = new Uri(Url);
                var httpResponse = await client.GetAsync(Url);
                if (httpResponse.IsSuccessStatusCode)
                {
                    string Result = httpResponse.Content.ReadAsStringAsync().Result;
                    return Result;
                }
            }
            catch
            {
            }
            return null;
        }

        public async Task<object> PostJson(string Uri,Medicine medicine)
        {
            try {
                string Url = "http://localhost:27129/api/" + Uri;
                var client = new HttpClient();
                client.BaseAddress = new Uri(Uri);
                var json = JsonConvert.SerializeObject(medicine);
                var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponse =
                await client.PostAsync(Url, httpcontent);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return true;
                }
            }
             catch
            {
            }
            return null;

        }

        public async Task<object> DeleteJson(string Uri)
        {
            try
            {
                string Url = "http://localhost:27129/api/" + Uri;
                var client = new HttpClient();
                client.BaseAddress = new Uri(Url);
                var httpResponse = await client.DeleteAsync(Url);
                if (httpResponse.IsSuccessStatusCode)
                {
                    string Result = httpResponse.Content.ReadAsStringAsync().Result;
                    return Result;
                }
            }
            catch
            {
            }
            return null;
        }

        public async Task<object> PutJson(string Uri, Medicine medicine)
        {
            try
            {
                string Url = "http://localhost:27129/api/" + Uri;
                var client = new HttpClient();
                client.BaseAddress = new Uri(Url);
                var json = JsonConvert.SerializeObject(medicine);
                var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponse =
                await client.PutAsync(Url, httpcontent);
                if (httpResponse.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch
            {
            }
            return null;

        }
        public async Task<Medicine> GetMedicine(int medicineId)
        {
            var Result = await getJson("Home/GetMedicineDetails/" + medicineId);
            return JsonConvert.DeserializeObject<Medicine>(Result.ToString());
        }

        public async Task<IEnumerable<Medicine>> GetMedicines()
        {
            var Result = await getJson("Home/GetMedicines");
            if(Result!=null)
            return JsonConvert.DeserializeObject<IEnumerable<Medicine>>(Result.ToString());
            return null;
        }

        public async Task<IEnumerable<Medicine>> SearchMedicine(string Value)
        {
            var Result = await getJson("Home/MedicineSearch/" + Value);
            return JsonConvert.DeserializeObject<IEnumerable<Medicine>>(Result.ToString());
        }

        public async Task<string> DeleteMedicine(int medicineId)
        {
            var Result = await DeleteJson("Home/MedicineDelete/" + medicineId);
            return null;
        }

      

        public async Task<object> AddMedicine(Medicine medicine)
        {
            var Result = await PostJson("Home/CreateMedicine", medicine);
            return Result;
        }

        public async Task<object> UpdateMedicine(Medicine medicine)
        {
            var Result = await PutJson("Home/MedicineUpdate", medicine);
            return Result;
        }


        public async Task<IEnumerable<ManufactureCompany>> GetCompanies()
        {
            var Result = await getJson("Home/GetCompanies");
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
