﻿using System;
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
    public partial class MainAssign : ContentPage
    {
        public MainAssign()
        {
            InitializeComponent();

            GetIndigentDetailsAsync();


        }

        async void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var itemSelectedData = e.SelectedItem as Indigents;
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Page1(itemSelectedData)
                {
                    BindingContext = e.SelectedItem as Indigents
                });
            }
        }

        HttpClient client = new HttpClient();

        public async Task<List<Indigents>> GetIndigentDetailsAsync()
        {

            try
            {
                var response = await client.GetStringAsync("https://munipoiapp.herokuapp.com/api/applications/New/KemptonMobileward1");
                var IndigentDetails = JsonConvert.DeserializeObject<List<Indigents>>(response);
                ListView.ItemsSource = IndigentDetails;
                ProgressLoader.IsRunning = false;
                return IndigentDetails;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }




    }
}