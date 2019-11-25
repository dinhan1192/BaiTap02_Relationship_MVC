using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap02_Relationship_MVC.Models
{
    public class Article
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}