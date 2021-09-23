using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApplication.Model
{
    public class Patient
    {
        public string FullName { get; set; }
        public Patient(string fullName)
        {
            FullName = fullName;
        }
    }
}
