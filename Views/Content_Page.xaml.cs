using Meteo_APP.Models;

namespace Meteo_APP.Views;

public partial class Content_Page : ContentPage
{
	public Content_Page()
	{
		InitializeComponent();

		BindingContext = new City_Search();
	}

    private void SearchClicked(object sender, EventArgs e)
    {
		(BindingContext as City_Search).SearchCity(SearchCityBar.Text);
    }
}