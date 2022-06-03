using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_Do_List.Models
{
    public class Category
    {
        public string Name { get; set; }

        public Guid ID { get; set; }

        public List<Item> Item { get; set; }


    }
}