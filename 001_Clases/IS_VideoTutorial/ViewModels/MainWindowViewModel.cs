using IS_VideoTutorial.Models;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_VideoTutorial.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region Fields
        private string _employeeName;
        private ObservableCollection<Employee> _employeeCollection;

        public string EmployeeName
        {
            get { return _employeeName; }
            set { SetProperty(ref _employeeName, value); }
        }

        public ObservableCollection<Employee> EmployeeCollection
        {
            get { return _employeeCollection; }
            set { SetProperty(ref _employeeCollection, value); }
        }


        #endregion

        #region Commands
        public DelegateCommand OKButtonCommand { get; private set; }

        public void OKButton()
        {
            if (!String.IsNullOrWhiteSpace(EmployeeName))
            {
                Employee employee = new Employee();
                employee.Name = EmployeeName;
                
                EmployeeCollection.Add(employee);
                EmployeeName = "";
            }
        }
        #endregion

        public MainWindowViewModel()
        {
            OKButtonCommand = new DelegateCommand(OKButton);
            EmployeeCollection = new ObservableCollection<Employee>();
        }
    }
}
