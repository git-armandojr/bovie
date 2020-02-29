using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Bovie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetail : ContentPage
    {
        public MenuDetail()
        {
            InitializeComponent();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                              new Position(-23.73815, -46.58407),
                              Distance.FromMiles(0.2)));


            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-23.73815, -46.58407),
                Label = "FTT",
                Address = "www.ftt.com.br",
            };

            Mapa.Pins.Add(pin);
        }
    }
}