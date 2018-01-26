using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public partial class Assignmt : ContentPage
	{
        void Assignments_Tapped(object sender, EventArgs e)
        {
            var page = new MainAssign();
            PlaceHolder.Content = page.Content;
        }

        void Accepted_Tapped(object sender, EventArgs e)
        {
            var page = new Accptd();
            PlaceHolder.Content = page.Content;
        }

        void Rejected_Tapped(object sender, EventArgs e)
        {
            var page = new Rejctd();
            PlaceHolder.Content = page.Content;
        }

        void Closed_Tapped(object sender, EventArgs e)
        {
            var page = new Clsed();
            PlaceHolder.Content = page.Content;
        }


        public Assignmt()
        {
            InitializeComponent();

        }

    }
}