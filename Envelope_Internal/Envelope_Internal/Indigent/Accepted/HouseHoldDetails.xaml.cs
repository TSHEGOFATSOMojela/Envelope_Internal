using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;
using Envelope_Internal.Indigent.Accepted;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Droid;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Timers;
using Plugin.Media;
using SQLite;
using Envelope_Internal.Indigent.Assignment;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HouseHoldDetails : ContentPage
	{
        Indigents indigentDetails;
        public HouseHoldDetails (Indigents indigentDetails)
		{
			InitializeComponent ();
            var myList = indigentDetails.indigentApplicationDetails.householdDetail;
            //ArrayList accepted1 = new ArrayList();

            for (int i = 0; i < myList.Count; i++)
            {
                
                BindingContext = indigentDetails.indigentApplicationDetails.householdDetail[i];
            }
        }

    

    }
}