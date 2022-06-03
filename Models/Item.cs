using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_Do_List.Models
{
    public class Item
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public bool Completed { get; set; }
    }
}