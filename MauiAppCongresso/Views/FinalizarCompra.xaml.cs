namespace MauiAppCongresso.Views;

public partial class FinalizarCompra : ContentPage
{
    private object stp_ingressos;

    public FinalizarCompra()
    {
    }

    public FinalizarCompra(decimal valorTotal)
    {
        InitializeComponent();

        var vm = new FinalizarCompra();
        vm.ValorTotal = valorTotal;
        BindingContext = vm;
    }

    public decimal ValorTotal { get; set; }
    public object QntIngressos { get; private set; }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        int quantidadeIngressos = (int)stp_ingressos;
        Console.WriteLine($"Ingressos selecionados: {quantidadeIngressos}"); // Debug
        await Navigation.PushAsync(new FinalizarCompra { BindingContext = quantidadeIngressos });
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is int numeroIngressos)
        {
            Console.WriteLine($"Número recebido na página: {numeroIngressos}"); // Debug
            QntIngressos = numeroIngressos.ToString();
        }
        else
        {
            Console.WriteLine("Erro: BindingContext não é um número.");
        }
    }

}

