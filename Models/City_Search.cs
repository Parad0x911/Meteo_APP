using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace Meteo_APP.Models
{
    public class City_Search
    {
        public ObservableCollection<ListView> SearchResult { get; set; } = new();

        private RestClient _client;
        private City_Search BindingContext;

        public City_Search()
        {
            _client = new RestClient("https://api.openweathermap.org/geo/1.0");
        }

        public async void SearchCity(string cityname)
        {
            SearchResult.Clear();

            RestRequest request = new RestRequest("direct");
            request.AddParameter("q", cityname);
            request.AddParameter("limit", 8);
            request.AddParameter("appid", "6385c345fecf8e9f5f4cba0d91b1edb2");

            RestResponse response = await _client.GetAsync(request);
            if (response.IsSuccessful)
            {
                JsonSerializerOptions options = new();
                options.PropertyNameCaseInsensitive = true;

                JsonDocument doc = JsonDocument.Parse(response.Content);
                JsonElement root = doc.RootElement;
                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    ListView city = root[i].Deserialize<ListView>(options);
                    SearchResult.Add(city);
                }
            }
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem!= null && e.SelectedItem is ListView city)
            {
                var navigationParameter = new Dictionary<string, object>();
                navigationParameter.Add(nameof(Meteo_APP), navigationParameter);

                await Shell.Current.GoToAsync(nameof(Meteo_APP), navigationParameter);
                ListView.SelectedItem = null;
                (BindingContext as City_Search).SearchResult.Clear();

                
            }
                
        }
    }
}
