using BeautyShop.Contexts;
using BeautyShop.Messages;
using BeautyShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.ViewModels
{
    public partial class ClientViewModel : ObservableObject, IRecipient<LoggedInClientMessage>
    {
        [ObservableProperty]
        private Client _client;

        [ObservableProperty]
        private List<Employee> _employees;

        [ObservableProperty]
        private Employee _selectedEmployee;

        [ObservableProperty]
        private List<EmployeeSchedule> employeeSchedules;

        public ClientViewModel()
        {
            var context = new BeautyShopDBContext();
            WeakReferenceMessenger.Default.Register(this);
            _employees = context.Employees.ToList();
        }
        
        public void Receive(LoggedInClientMessage message)
        {
            Client = message.Value;
            WeakReferenceMessenger.Default.UnregisterAll(this);
        }

        [RelayCommand]
        private void ShowSchedule()
        {
            var context = new BeautyShopDBContext();
            if (SelectedEmployee != null)
            {
                EmployeeSchedules = context.EmployeeSchedules.Where(scheduleItem => scheduleItem.EmployeeId == SelectedEmployee.Id).ToList();
            }
        }

    }
}
