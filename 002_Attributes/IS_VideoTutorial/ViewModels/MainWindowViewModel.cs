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
        private IEnumerable<Positions> _positionsCollection;
        private Positions _selectedPosition;
        private DateTime _selectedBirthDate;

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
        public IEnumerable<Positions> PositionsCollection
        {
            get { return _positionsCollection; }
            set { SetProperty(ref _positionsCollection, value); }
        }

        public Positions SelectedPosition
        {
            get { return _selectedPosition; }
            set { SetProperty(ref _selectedPosition, value); }
        }

        public DateTime SelectedBirthDate
        {
            get { return _selectedBirthDate; }
            set { SetProperty(ref _selectedBirthDate, value); }
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
                employee.BirthDate = SelectedBirthDate;
                employee.Position = SelectedPosition;

                EmployeeCollection.Add(employee);
            }
        }
        #endregion

        public MainWindowViewModel()
        {
            OKButtonCommand = new DelegateCommand(OKButton);
            EmployeeCollection = new ObservableCollection<Employee>();
            PositionsCollection = Enum.GetValues(typeof(Positions)).Cast<Positions>();
            SelectedBirthDate = new DateTime(1970, 1, 1);
        }
    }
}
