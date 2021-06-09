using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Demo_UWP
{
  
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Pet> _pets = new ObservableCollection<Pet>();
        public List<ComboBoxData> petTypes = new List<ComboBoxData>();
        public MainPage()
        {

            this.InitializeComponent();

            petTypes.Add(new ComboBoxData("1", "dog"));
            petTypes.Add(new ComboBoxData("2", "cat"));
            petTypes.Add(new ComboBoxData("3", "fish"));

            _pets.Add(new Pet("Rex", "brown", "2",petTypes));
            _pets.Add(new Pet("Fluffy", "white", "1",petTypes));
            _pets.Add(new Pet("Goldy", "gold", "3", petTypes));
           

            MainLV.ItemsSource = _pets;

        }

        private void cbPetType_Changed(object sender, SelectionChangedEventArgs e)
        {
            // nothing required here for now (afaik)
        }

        private void cbPetTypesTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // nothing required here for now 
        }

        private void testButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            foreach (Pet p in _pets)
            {
                string s = p.name;
            }
        }
    }
}
