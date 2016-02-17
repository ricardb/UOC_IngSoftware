using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_VideoTutorial.Models
{
    public class Employee : BindableBase
    {
        private string _name;
        private DateTime _birthDate;
        private Positions _position;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                SetProperty(ref _birthDate, value);
            }
        }

        public Positions Position
        {
            get
            {
                return _position;
            }

            set
            {
                SetProperty(ref _position, value);
            }
        }
    }
}
