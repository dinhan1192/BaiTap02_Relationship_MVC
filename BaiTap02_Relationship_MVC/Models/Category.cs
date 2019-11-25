using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap02_Relationship_MVC.Models
{
    public class Category
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}