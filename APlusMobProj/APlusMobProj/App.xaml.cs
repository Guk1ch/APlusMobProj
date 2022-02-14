using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APlusMobProj.Data;
using System.IO;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "AplusFont")]

namespace APlusMobProj
{
	public partial class App : Application
	{
		static Datas data;
		public static Datas Datas
		{
			get
			{
				if (data == null)
				{
					data = new Datas(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aplusbd.db3"));
				}
				return data;
			}
		}
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new AutorizPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
