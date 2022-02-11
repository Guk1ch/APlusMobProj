using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlusMobProj.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProjInfoPage : TabbedPage
	{
		public ProjInfoPage(string p)
		{
			InitializeComponent();
		}
	}
}