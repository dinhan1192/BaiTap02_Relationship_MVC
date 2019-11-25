using BaiTap02_Relationship_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap02_Relationship_MVC.Util
{
    public class CategoryUtil
    {
        private static BaiTap02_Relationship_MVCContext db = new BaiTap02_Relationship_MVCContext();
        private static List<Category> _listCategories;

        public static List<Category> GetCategories()
        {
            if (_listCategories == null)
            {
                _listCategories = db.Categories.ToList();
            }
            return _listCategories;
        }

        public static List<SelectListItem> GetCategoriesAsDropDownList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            if (_listCategories == null)
            {
                _listCategories = db.Categories.ToList();
            }

            foreach (var category in _listCategories)
            {
                list.Add(new SelectListItem { Text = category.Name, Value = category.Id.ToString() });
            }
            return list;
        }

        public static void SetCategories(List<Category> categories)
        {
            _listCategories = categories;
        }
    }
}