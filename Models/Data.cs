using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_Do_List.Models
{
    public static class Data
    {
        public static List<Category> categories = new List<Category>();

        public static Category FindCategory(Guid id)
        {
            Category cat = null;

            foreach (Category c in categories)
            {
                if (c.ID.Equals(id))
                {
                    cat = c;
                    break;
                }
            }
            return cat;
        }
    }
}