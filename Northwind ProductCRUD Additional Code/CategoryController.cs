using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
using System.ComponentModel;
#endregion

namespace NorthwindSystem.BLL
{
    [DataObject]
    public class CategoryController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Category> Category_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category Category_Get(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Find(categoryid);
            }
        }
    }
}
