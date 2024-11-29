namespace PruebaProgreso2CamiloBrazales.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
    private void Recarga(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }
}