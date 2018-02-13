using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;

using System.Net.Http;
using Newtonsoft.Json;
using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Assignment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private Indigents itemSelectedData;


        public Page1(Indigents itemSelectedData)
        {
            InitializeComponent();
            BindingContext = itemSelectedData;
        }
        //accept assignment
        private async void AcceptedClicked(object sender, EventArgs e)
        {
        
        }
        //accept assignment
        private async void UnavailableClicked(object sender, EventArgs e)
        {
            

        }



     
    }
}