using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PersonInfo.PersonInfo
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoController Controller { get; set; }

        public PersonInfoForm()
        {
            InitializeComponent();

            Controller = new PersonInfoController();

            SetupWebBrowser();
            SetupBindings();
        }

        private void SetupBindings()
        {
            personInfoBindingSource.DataSource = Controller.ViewModel;
        }

        private void SetupWebBrowser()
        {
            //set the Url of the webBrowser to the local html file
            webBrowser1.Url = new Uri(String.Format("file:///{0}/index.html", Directory.GetCurrentDirectory()));

            //set the class that will be updated by the web part
            webBrowser1.ObjectForScripting = Controller.ViewModel;
        }
    }
}
