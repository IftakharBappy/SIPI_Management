using DAL.InventoryManagement;
using ENTITY.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.InventoryManagement
{
    public class InventoryManager
    {
        InventoryGetway inventoryGrtwayObj = new InventoryGetway();
        ProductMasterEntry_inventoryGetway inventoryGrtway_inventoryGetwayObj = new ProductMasterEntry_inventoryGetway();
        public void SaveBrandName(BrandName _brandName)
        {
            inventoryGrtwayObj.SaveBrandName(_brandName);
        }

        public List<BrandName> GetAllBrandName()
        {
            return inventoryGrtwayObj.GetAllBrandName();
        }

        public void SaveBrandCategory(BrandCategory _brandCategory)
        {
            inventoryGrtwayObj.SaveBrandCategory(_brandCategory);

        }

        public List<BrandCategory> LoadAllBrandCategory()
        {
            return inventoryGrtwayObj.LoadAllBrandCategory();

        }

        public void SaveUnitType(UnitType _unittypeObj)
        {
            inventoryGrtwayObj.SaveUnitType(_unittypeObj);
        }
        public List<UnitType> LoadAllUnitType()
        {
            return inventoryGrtwayObj.LoadAllUnitType();
        }


    }
}
