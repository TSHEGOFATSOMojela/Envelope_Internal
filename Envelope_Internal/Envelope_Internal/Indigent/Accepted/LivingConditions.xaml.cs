using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Accepted;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LivingConditions : ContentPage
	{
         Indigents indigentDetails;
        public LivingConditions(Indigents indigentDetails)
		{
			InitializeComponent ();
            BindingContext = indigentDetails;
        }
	}
}