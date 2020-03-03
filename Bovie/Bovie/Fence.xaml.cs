using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bovie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fence : ContentPage
    {
        public IList<Coordinate> Coordinates { get; private set; }

        public Fence()
        {
            InitializeComponent();

            Coordinates = new List<Coordinate>();

            Coordinates.Add(new Coordinate
            {
                Point = 1,
                Latitude = "-23.73815",
                Longitude = "-46.58407"
            });

            Coordinates.Add(new Coordinate
            {
                Point = 2,
                Latitude = "-23.73815",
                Longitude = "-46.58407"
            });

            Coordinates.Add(new Coordinate
            {
                Point = 3,
                Latitude = "-23.73815",
                Longitude = "-46.58407"
            });

            BindingContext = this;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Coordinate selectedItem = e.SelectedItem as Coordinate;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Coordinate tappedItem = e.Item as Coordinate;
        }
    }
}