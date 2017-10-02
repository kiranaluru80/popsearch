using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ReadDataFromJson
{
	public partial class ReadDataFromJsonPage : ContentPage
	{
		protected ReadDataViewModel vm;
		public ReadDataFromJsonPage()
		{
			InitializeComponent();

			vm = new ReadDataViewModel();
			this.BindingContext = vm;
			searchRef.TextChanged += (object sender, TextChangedEventArgs e) =>
			{
                if (string.IsNullOrEmpty(e.NewTextValue))
                {
                    listView.IsVisible = false;
					//vm.textChangedMethod(e.NewTextValue);
                }else{
					listView.IsVisible = true;
					vm.textChangedMethod(e.NewTextValue);
                }
			};
		}
	}
}
