using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialValues.Model
{
    public class Movements
    {
        public int ID { get; set; }
        public string OperationType { get; set; }
        public float Coast { get; set; }
        public int Number { get; set; }
        public int RoomID { get; set; }
    }
}
