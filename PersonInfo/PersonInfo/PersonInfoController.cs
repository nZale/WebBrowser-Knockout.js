using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PersonInfo.PersonInfo
{
    public class PersonInfoController
    {
        public PersonInfoViewModel ViewModel { get; set; }

        public PersonInfoController()
        {
            ViewModel = new PersonInfoViewModel();
        }

        public void Save()
        {
            // save to database ...
        }
    }
}
