using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace testApp
{
    public partial class FirstPage : ContentPage
    {
        public Contacts TheContact { get; set; }
        public FirstPage()
        {
            TheContact = new Contacts();
            TheContact.FirstName = "Richard";
            TheContact.LastName = "Presley";
            TheContact.Email = "RP@Gmail.com";
            BindingContext = TheContact;
            InitializeComponent();
        }
    }
}
