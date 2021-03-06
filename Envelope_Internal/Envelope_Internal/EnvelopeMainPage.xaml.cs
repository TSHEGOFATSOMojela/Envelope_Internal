﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Envelope_Internal.Indigent.Assignment;
    using Envelope_Internal.Indigent;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    namespace Envelope_Internal
    {
	    [XamlCompilation(XamlCompilationOptions.Compile)]
	    public partial class EnvelopeMainPage : MasterDetailPage
	    {
        private double _width = 0;
        private double _Height = 0;
            //Envelope Main Page Constructor
		    public EnvelopeMainPage()
		    {
			    InitializeComponent ();
                //Title = ((App)App.Current).username.ToString();
               //Binding Items to View
            SettingListView.ItemsSource = new List<settingLv>
                {
                 //Declearing an item Name
                    new settingLv
                    { SettingOptions = "Change Password"}

                };

            }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if(_width != width || _Height != height)
            {

                _width = width;
                _Height = height;


                if (width > height)
                {
                   // OuterLayout.Orientation = StackOrientation.Horizontal;

                }

                else
                {
                   // OuterLayout.Orientation = StackOrientation.Vertical;
                }
            }

          
        }
            //Log out label
            private async void LogOut_Tapped(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new EnvelopeLoginPage());
            }

            //General label
            private async void GeneralClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new GeneralPage());

            }
            //Settings label 
            private async void OnSettingsClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new SettingsPage());
            }
            //Indigent image 
            private async void OnIndigentClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new TappedPageNavigation());
            }
      
    }
    }