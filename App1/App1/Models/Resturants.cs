using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Resturants
    {
        public int id { get; set; }
        public string  name{ get; set; }
        public Commands cmd { get; set; }
        public int qt;
        public int total { get; set; }
    }
}
