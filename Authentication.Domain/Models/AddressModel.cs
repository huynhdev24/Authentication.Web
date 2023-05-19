using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class AddressModel
    {
        public string? Name { get; set; }
        public string? HouseName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Pin { get; set; }
    }
}
