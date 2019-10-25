using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Resturants
    {
        public int id { get; set; }
        public string  name{ get; set; }
        public  string cmd { get; set; }
        public int qt;
        public string nomclient { get; set; }

        public string tele { get; set; }

        public string addr { get; set; }
        public decimal total { get; set; }
        public string Datetime { get; set; }
    }
}
