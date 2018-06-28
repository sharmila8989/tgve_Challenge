using System;
using System.Collections.Generic;
using System.Linq;
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
using WebAPI_tgve;
using System.Net.Http;
using System.Net.Http.Headers;


namespace tgve_App
{
    /// <summary>
    /// Interaction logic for TourEventPage.xaml
    /// </summary>
    public partial class TourEventPage : Page
    {
        //WebAPI_tgve.Controllers.TourEventsController obj = new WebAPI_tgve.Controllers.TourEventsController();
        public List<Booking> bookingList = new List<Booking>();
      

        public TourEventPage()
        {
            InitializeComponent();
            
        }
        private void BindTourEvents()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:57923/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/tourevents").Result;
            if (response.IsSuccessStatusCode)
            {
                var events = response.Content.ReadAsAsync<IEnumerable<TourEvent>>().Result;
                lvTourEvents.ItemsSource = events;

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }
        private void BindClientDetails()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:57923/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/clients").Result;
            if (response.IsSuccessStatusCode)
            {
                var events = response.Content.ReadAsAsync<IEnumerable<Client>>().Result;
                lvClients.ItemsSource = events;

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
       
       

        private void bttnViewBookins_Click(object sender, RoutedEventArgs e)
        {

            var win = new bookingsPage();
            win.Show();

        }

        private void bttnViewTourEvents_Click(object sender, RoutedEventArgs e)
        {
            BindTourEvents();
        }

        private void bttnViewClients_Click(object sender, RoutedEventArgs e)
        {
            BindClientDetails();
        }
    }
}
