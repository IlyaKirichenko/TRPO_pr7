using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kirichenko_pr7.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public ObservableCollection<Pet> pets { get; set; } = new ObservableCollection<Pet>();

        public Pet newPet { get; set; } = new Pet();
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += LoadList;
        }

        public async void LoadList(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7188/");

                var response = await client.GetFromJsonAsync<List<Pet>>("api/v1/pet");
                if (response != null)
                {
                    pets.Clear();
                    foreach (var pet in response)
                    {
                        pets.Add(pet);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Список не загружен");
            }
        }
    }
}
