using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UWP
{
   public class ComboBoxData
    {
        public string CbID { get; set; }
        public string CbName { get; set; }


        public ComboBoxData()
        {
            // default values for each property.
            CbID = string.Empty;
            CbName = string.Empty;
        }

        public ComboBoxData(string cbID, string cbName)
        {
            CbID = cbID;
            CbName = cbName;
        }
    }
}
