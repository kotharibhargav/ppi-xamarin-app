using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace PPI.Views.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterMenuPage : ContentPage
	{
		public MasterMenuPage ()
		{
			InitializeComponent ();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        private void ImgExit_Tapped(object sender, EventArgs e)
        {
            Utilities.Common.MasterPage.IsPresented = false;
        }
    }
}