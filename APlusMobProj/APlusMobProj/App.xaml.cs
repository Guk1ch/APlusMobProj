using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APlusMobProj.Date;
using System.IO;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "AplusFont")]

namespace APlusMobProj
{
	public partial class App : Application
	{
		static Data data;
		public static Data data
		{
			get
			{
				if (data == null)
				{
					data = new Data(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aplusbd.db3"));
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
