using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTap02_Relationship_MVC.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BaiTap02_Relationship_MVCContext : DbContext
    {
        public BaiTap02_Relationship_MVCContext() : base("name=MySQLContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}