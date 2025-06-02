using MauiAppCongresso.Models;
using MauiAppCongresso.Views;
using System.ComponentModel;
using System.Linq;

namespace MauiAppCongresso
{
    public partial class App : Application
    {
        public List<Ingresso> lista_ingressos = new List<Ingresso>
{
    new Ingresso { PrimeiroDia = 30.0 },
    new Ingresso { SegundoDia = 35.0 },
    new Ingresso { TerceiroDia = 40.0 }
};
        public double ValorTotal
        {
            get
            {
                return lista_ingressos.Sum(i => i.Total);
            }
        }

        public class FinalizarCompraViewModel : INotifyPropertyChanged
        {
            private decimal valorTotal;
            public decimal ValorTotal
            {
                get => valorTotal;
                set
                {
                    if (valorTotal != value)
                    {
                        valorTotal = value;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ValorTotal)));
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PerfilCongresso());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}

