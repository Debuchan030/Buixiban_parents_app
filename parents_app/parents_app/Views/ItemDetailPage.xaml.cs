using parents_app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace parents_app.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}