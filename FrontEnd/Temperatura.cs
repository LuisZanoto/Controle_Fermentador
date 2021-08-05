using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    public class Temperatura
    {

        public string Location { get; set; }

        public decimal M1 { get; set; }

        public decimal M2 { get; set; }

        public decimal M3 { get; set; }

        public decimal M4 { get; set; }

        public decimal M5 { get; set; }

        public decimal M6 { get; set; }

        public decimal M7 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }







    }
}
