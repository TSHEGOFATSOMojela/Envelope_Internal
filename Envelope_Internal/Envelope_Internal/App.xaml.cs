using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;
using Envelope_Internal.Indigent.Data;
using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Envelope_Internal
{
	public partial class App : Application
	{
        static IndigentDB database;
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage (new MainPage());
		}

        public static IndigentDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new IndigentDB(DependencyService.Get<IFileHelper>().GetLocalFilePath("IndigentDB.db3"));
                }
                return database;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
