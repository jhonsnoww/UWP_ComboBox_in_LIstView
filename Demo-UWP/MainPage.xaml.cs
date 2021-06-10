using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Demo_UWP
{
  
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Pet> _pets = new ObservableCollection<Pet>();
        public ObservableCollection<ComboBoxData> petTypes = new ObservableCollection<ComboBoxData>();
        public ObservableCollection<ComboBoxData> petSubtypes = new ObservableCollection<ComboBoxData>();
        public MainPage()
        {

            this.InitializeComponent();

            petTypes.Add(new ComboBoxData("1", "dog"));
            petTypes.Add(new ComboBoxData("2", "cat"));
            petTypes.Add(new ComboBoxData("3", "fish"));
       
            _pets.Add(new Pet("Rex", "brown", "2",petTypes, petSubtypes));
           

            MainLV.ItemsSource = _pets;

        }

        private void cbPetType_Changed(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var pet = (Pet)combo.DataContext;
            var v =(ComboBoxData) combo.SelectedItem;

            //Pet pp = _pets.FirstOrDefault(p => p.petSubTypes == pet.petSubTypes);
            var i =  _pets.IndexOf(pet);
            Debug.WriteLine("Index :::" + i);
            _pets[i].petSubTypes.Clear();
            petSubtypes.Add(new ComboBoxData("3", "duck" + v.CbName));
            petSubtypes.Add(new ComboBoxData("4", "Goat" + v.CbName));
            _pets[i].petSubTypes = petSubtypes;


        }

        private void cbPetTypesTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // nothing required here for now 
        }

        private void testButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            foreach (Pet p in _pets)
            {
                string s = p.animal;
                Debug.WriteLine(p.animal);
            }
        }

        private void Less_Click(object sender, RoutedEventArgs e)
        {

        }

        private void More_Click(object sender, RoutedEventArgs e)
        {
            _pets.Add(new Pet("Fluffy", "white", "1", petTypes,petSubtypes));
        
        }

        private void ChangeDatda_Click(object sender, RoutedEventArgs e)
        {
          
            petTypes.Clear();
            petTypes.Add(new ComboBoxData("3", "duck"));
            petTypes.Add(new ComboBoxData("4", "Goat"));
            _pets[0].petTypes = petTypes;
        }

        private void cbPetSubType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
