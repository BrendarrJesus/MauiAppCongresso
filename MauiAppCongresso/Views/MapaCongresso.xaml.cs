namespace MauiAppCongresso.Views;

public partial class MapaCongresso : ContentPage
{
    public MapaCongresso()
    {
        InitializeComponent();
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
       int quantidade = (int)stp_ingressos.Value;
    decimal precoIngresso = 50m;
    decimal valorTotal = quantidade * precoIngresso;

    await Navigation.PushAsync(new FinalizarCompra(valorTotal));
    }


    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new PerfilCongresso());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK!");
        }
    }
}
