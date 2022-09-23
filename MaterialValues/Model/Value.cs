using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialValues.Model
{
    public class Value
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int PriceForOneCount { get; set; }
        public float Size { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public int SerialNumber { get; set; }
        public string Info { get; set; }
        public int SipplierID { get; set; }

    }
}
