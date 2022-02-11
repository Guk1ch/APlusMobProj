using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlusMobProj
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProjectsPage : ContentPage
	{
		public ProjectsPage()
		{
			InitializeComponent();
		}
		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Pages.CreateProjPage());
		}

		private async void project_listview_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
		{
			await Navigation.PushAsync(new Pages.ProjInfoPage(project_listview.SelectedItem.ToString()));
		}
	}
}