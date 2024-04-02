using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Text;

/* MUST DO: 1. Create mutipel pages. 2.  convert user input to Json 
   OPTIONAL: encrypted user input
 */

namespace ONWaRD05
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        //TO DO: creat button click to Create.xaml
        private async void Button_Clicked_Create(object sender, EventArgs e)
        {

        }
        //TO DO: creat button click to Manage.xaml
        private async void Button_Clicked_Manage(object sender, EventArgs e)
        {

        }
        //TO DO: creat button click to Setting.xaml
        private async void Button_Clicked_Setting(object sender, EventArgs e)
        {

        }

    }
}
