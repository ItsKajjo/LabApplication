using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApplication.Model
{
    public class Blood
    {
        public Blood(int code, string service, decimal price)
        {
            Code = code;
            Service = service;
            Price = price;
        }

        public int Code { get; set; }
        public string Service { get; set; }
        public decimal Price { get; set; }
    }
}
