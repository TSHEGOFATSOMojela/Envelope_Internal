using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AssignmentPage : ContentPage
	{
		public AssignmentPage ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var assignment = (Assignment1)BindingContext;
            await App.Database.SaveItemAsync(assignment);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var assignment = (Assignment1)BindingContext;
            await App.Database.DeleteItemAsync(assignment);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var assignment = (Assignment1)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(assignment.Name + " " + assignment.Notes);
        }
    }
}
