using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnfDemo.Models;
using Xamarin.Forms;

namespace OnfDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //BindingContext = new MainViewModel();
        }

        //private void Button_OnClicked(object sender, EventArgs e)
        //{
        //    var nom = NomEntry.Text;

        //    BonjourLabel.Text = "Bonjour " + nom;
        //}
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MainViewModel;

            var product = e.Item as Product;

            vm?.ListClicked(product);
        }
    }
}
