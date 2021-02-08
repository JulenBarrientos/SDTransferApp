using SDTransferApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SDTransferApp.Views
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