using LeMeilleurRepetiteur.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LeMeilleurRepetiteur.Views
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