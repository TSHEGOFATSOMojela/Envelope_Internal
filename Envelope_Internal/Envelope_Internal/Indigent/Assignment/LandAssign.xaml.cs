using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Assignment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandAssign : ContentPage
	{
        private Indigents itemSelectedData;

    

        public LandAssign(Indigents itemSelectedData)
        {
            InitializeComponent();
            BindingContext = itemSelectedData;
        }
    }
}
