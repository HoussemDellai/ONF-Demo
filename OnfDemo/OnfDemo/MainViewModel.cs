using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using OnfDemo.Models;
using Xamarin.Forms;

namespace OnfDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IDatabaService _service;
        private string _message;
        private List<Product> _products;

        public string Nom { get; set; }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ICommand DitesBonjourCommand
        {
            get
            {
                return new Command(() => DitesBonjour());
            }
        }

        public void DitesBonjour()
        {
            Message = "Bonjour " + Nom;
        }

        public List<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {    
        }

        public MainViewModel(IDatabaService service)
        {
            _service = service;

            Products = new List<Product>
            {
                new Product{ Name = "X-BOX-2", Cost = 400 },
                new Product{ Name = "PS 32", Cost = 600 },
                new Product{ Name = "PS 33", Cost = 600 },
                new Product{ Name = "PS 5", Cost = 800 },
                new Product{ Name = "Laptop", Cost = 900 },
                new Product{ Name = "XBOX", Cost = 4000 },
                new Product{ Name = "Smartphone", Cost = 400 },
                new Product{ Name = "XBOX", Cost = 40 },
                new Product{ Name = "XBOX", Cost = 40 },
                new Product{ Name = "XBOX", Cost = 40 },
                new Product{ Name = "XBOX", Cost = 40 },
                new Product{ Name = "XBOX One", Cost = 400 },
                new Product{ Name = "WII", Cost = 200 },
                new Product{ Name = "Tetris", Cost = 700 },
            };
        }

        public void GetData()
        {
            _service.GetDataFromWebService();
        }

        public List<string> Options
        {
            get
            {
                return new List<string>
                {
                    "Option 1", "Option 2", "Option 3"
                };
            }
        }

        public void ListClicked(Product product)
        {
            Message = "Tu as selectionné le produit: " + product.Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public interface IDatabaService
    {
        List<Product> GetDataFromWebService();
    }

    public class DatabaService : IDatabaService
    {
        public List<Product> GetDataFromWebService()
        {
            // code qui accede au web service
            // httpClient.GetString(URL)
        }
    }
}
