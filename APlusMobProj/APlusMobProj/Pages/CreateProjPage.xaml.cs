using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APlusMobProj.Models;

namespace APlusMobProj.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateProjPage : ContentPage
	{
		public CreateProjPage()
		{
			InitializeComponent();
		}

		private void btn_Cancel_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopAsync();
		}

		private async void btn_Add_Clicked(object sender, EventArgs e)
		{
			var project = (AplusModel)BindingContext;
			if (!String.IsNullOrEmpty(project.NameProject))
			{
				App.Datas.SaveProject(project);
			}
			await this.Navigation.PopAsync();
		}
	}
}