using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Interface
{
    public interface HttpRequestInterface
    {
         Task<object> getJson(string Uri);
         Task<object> PostJson(string Uri, Medicine medicine);
         Task<object> DeleteJson(string Uri);
         Task<object> PutJson(string Uri, Medicine medicine);
    }
}
