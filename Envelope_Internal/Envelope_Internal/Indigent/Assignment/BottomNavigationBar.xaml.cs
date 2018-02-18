    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    namespace Envelope_Internal.Indigent.Assignment

    { 

        [XamlCompilation(XamlCompilationOptions.Compile)]

	    public partial class BottomNavigationBar : ContentPage
        {

            //Assignments page button
            void Assignments_Tapped(object sender, EventArgs e)
            {
                //Assign Assignment list page to a variable page
               var page = new AssignmentList();

                //Pass Assignment list Content
               PlaceHolder.Content = page.Content;
            }
    
           //Accepted assignments button 
            void Accepted_Tapped(object sender, EventArgs e)
            {
                //Assign Accepted Assignment list page to a variable page

                var page = new AccptedAssignmentsList();

                //Pass Accepted Assignment list Content

                PlaceHolder.Content = page.Content;
            }

            //Rejected assignments button 
            void Rejected_Tapped(object sender, EventArgs e)
            {
                //Assign Rejected Assignment list page to a variable page

                var page = new RejectedAssignments();

                //Pass Rejected Assignment list Content
                PlaceHolder.Content = page.Content;
            }

            // Closed assignments button
            void Closed_Tapped(object sender, EventArgs e)
            {
                //Assign Closed Assignment list page to a variable page

                var page = new ClosedAssignments();

                //Pass Closed Assignment list Content

                PlaceHolder.Content = page.Content;
            }

            //Botttom navigation Page Constructor
            public BottomNavigationBar()
            {
                InitializeComponent();

            }
      

        }
    }