using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsABCD.BLL
{
    class CategoriesBLL
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }

    }
}
