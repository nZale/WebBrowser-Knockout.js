using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PersonInfo.PersonInfo
{
    [ComVisibleAttribute(true)]
    public class PersonInfoViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _activity;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        public string Activity
        {
            get { return _activity; }
            set
            {
                _activity = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
