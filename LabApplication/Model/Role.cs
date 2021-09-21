using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApplication.Model
{
    /// <summary>
    /// Роли юзеров
    /// </summary>
    public enum Role : byte
    {
        [Description("Лаборант")] LaboratoryAssistant,
        [Description("Администратор системы")] SystemAdministrator
    }
}
