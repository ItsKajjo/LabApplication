using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApplication.Model;

namespace LabApplication.Services
{
    // скорее всего это плохая реализация, но пока что у меня нет других идей
    public static class CurrentAccount
    {
        public static User CurrentUser { get; set; }
    }
}
