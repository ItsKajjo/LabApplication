using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LabApplication.Model;

namespace LabApplication.Services
{
    public class Loader
    {
        private string pathToBlood = Path.Combine(Environment.CurrentDirectory, @"Resources\Blood.txt");
        private string pathToPatients = Path.Combine(Environment.CurrentDirectory, @"Resources\Patients.txt");
        public List<Blood> LoadBlood()
        {
            List<Blood> bloods = new List<Blood>();

            try
            {
                string[] lines = File.ReadAllLines(pathToBlood);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] temp = lines[i].Split(',');
                    int code = Int32.Parse(temp[0]);
                    string service = temp[1];
                    decimal price = decimal.Parse(temp[2]);
                    bloods.Add(new Blood(code, service, price));
                }
                return bloods;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки информации о крови");
                Debug.WriteLine($"LoadBlood Error \"{ex.Message}\"");
                return bloods;
            }
        }

        public List<Patient> LoadPatients()
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                string[] lines = File.ReadAllLines(pathToPatients);
                for (int i = 1; i < lines.Length; i++)
                {
                    patients.Add(new Patient(lines[i]));
                }
                return patients;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки информации о пациентах");
                Debug.WriteLine($"LoadBlood Error \"{ex.Message}\"");
                return patients;
            }
        }
    }
}
