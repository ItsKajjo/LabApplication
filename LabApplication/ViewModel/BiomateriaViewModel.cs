using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LabApplication.Commands;
using LabApplication.Model;
using LabApplication.Services;

namespace LabApplication.ViewModel
{
    public class BiomateriaViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private RelayCommand addServiceCommand;
        public BiomateriaViewModel()
        {
            AddedServices = new ObservableCollection<Blood>();
            AddedServices.CollectionChanged += new NotifyCollectionChangedEventHandler(OnAddedServicesChanged);
        }

        private void OnAddedServicesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            decimal sum = 0;
            foreach (Blood blood in AddedServices)
            {
                sum += blood.Price;
            }
            Price = sum;
        }
        private decimal price;
        public decimal Price
        {
            get => price;
            set => SetPropertyChanged(ref price, value);
        }
        private List<Patient> patients;
        public List<Patient> Patients
        {
            get
            {
                Loader loader = new Loader();
                patients = loader.LoadPatients();
                return patients;
            }
        }
        private List<Blood> bloods;
        public List<Blood> Bloods
        {
            get
            {
                Loader loader = new Loader();
                bloods = loader.LoadBlood();
                return bloods;
            }
        }
        private ObservableCollection<Blood> addedServies;
        private RelayCommand createOrderCommand;

        public ObservableCollection<Blood> AddedServices
        {
            get => addedServies;
            set => SetPropertyChanged(ref addedServies, value);
        }

        // хранит выбранную услугу
        public Blood SelectedService { get; set; }
        public RelayCommand AddServiceCommand => addServiceCommand ??
            (addServiceCommand = new RelayCommand(obj =>
            {
                if (SelectedService != null)
                {
                    AddedServices.Add(SelectedService);
                }
            }));

        public Patient SelectedPatient { get; set; }
        public RelayCommand CreateOrderCommand => createOrderCommand ??
            (createOrderCommand = new RelayCommand(obj =>
            {
                if (SelectedPatient != null && AddedServices.Count > 0)
                {
                    MessageBox.Show($"Заказ на сумму {Price} для пациента {SelectedPatient.FullName} сформирован.", "Заказ сформирован",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Для заказа необходимо заполнить все поля");
                }
            }));
    }
}
