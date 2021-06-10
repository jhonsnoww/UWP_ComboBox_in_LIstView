using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UWP
{
   public class Pet
    {
        public string name { get; set; }
        public string color { get; set; }
        public string animal { get; set; }
        public ObservableCollection<ComboBoxData> petTypes { get; set; }
        public ObservableCollection<ComboBoxData> petSubTypes { get; set; }


        public Pet()
        {
            // default values for each property.
            name = string.Empty;
            color = string.Empty;
            animal = string.Empty;
            petTypes = new ObservableCollection<ComboBoxData>();
            petSubTypes = new ObservableCollection<ComboBoxData>();
        }

        public Pet(string name_in, string color_in, string animal_in, 
            ObservableCollection<ComboBoxData> petTypes_id, ObservableCollection<ComboBoxData> petSubTypes_in)
        {
            name = name_in;
            color = color_in;
            animal = animal_in;
            petTypes = petTypes_id;
            petSubTypes = petSubTypes_in;

        }
    }
}
