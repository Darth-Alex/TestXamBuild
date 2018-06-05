using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        class tmp{
            public string test => "ABC";
        }
     
        public MainPage()
        {
            InitializeComponent();

            tmp temp = new tmp();
            string res = JsonConvert.SerializeObject(temp);
        }
    }
}
