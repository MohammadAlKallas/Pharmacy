using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ManufactureCompany
    {
        public byte Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
