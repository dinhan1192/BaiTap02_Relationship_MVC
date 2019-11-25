using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTap02_Relationship_MVC.Models
{
    public class BaiTap02_Relationship_MVCContextFake : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BaiTap02_Relationship_MVCContextFake() : base("name=BaiTap02_Relationship_MVCContextFake")
        {
        }

        public System.Data.Entity.DbSet<BaiTap02_Relationship_MVC.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<BaiTap02_Relationship_MVC.Models.Article> Articles { get; set; }
    }
}
