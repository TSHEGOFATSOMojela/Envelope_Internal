using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;

namespace Envelope_Internal.Indigent.Assignment
{
    public class AcceptedAssignDetailsCS : ContentPage
    {
        public AcceptedAssignDetailsCS()
        {
            Title = "Todo Item";

            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var notesEntry = new Entry();
            notesEntry.SetBinding(Entry.TextProperty, "Notes");

            var doneSwitch = new Switch();
            doneSwitch.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var todoItem = (Assignment1)BindingContext;
                await App.Database.SaveItemAsync(todoItem);
                await Navigation.PopAsync();
            };

            var deleteButton = new Button { Text = "Delete" };
            deleteButton.Clicked += async (sender, e) =>
            {
                var todoItem = (Assignment1)BindingContext;
                await App.Database.DeleteItemAsync(todoItem);
                await Navigation.PopAsync();
            };
        }
    }
}
