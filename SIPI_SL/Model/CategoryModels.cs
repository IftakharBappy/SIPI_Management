using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.PIS;

namespace SIPI_SL.Model
{
 public   class CategoryModels
    {
        private Category category;

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
        private List<Category> categoryList;

        public List<Category> CategoryList
        {
            get { return categoryList; }
            set { categoryList = value; }
        }
        private string categoryID;

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
    }
}
