using DATA;
using ENTITY.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.InventoryManagement
{
    public class InventoryGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        public void SaveBrandName(BrandName _brandName)
        {
            var newBrandName = new INVENTORY_BRAND_NAME
            {
                BrandName = _brandName.InventoryBrandName,
                BrandDiscription = _brandName.BrandDiscription,
                ContactInfo = _brandName.ContactInfo,

            };
            datacontextObj.INVENTORY_BRAND_NAME.Add(newBrandName);
            datacontextObj.SaveChanges();
        }

        public List<BrandName> GetAllBrandName()
        {
            List<BrandName> brabdNameList = new List<BrandName>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.INVENTORY_BRAND_NAME select j).Distinct())
            {
                BrandName brandNameObj = new BrandName();
                brandNameObj.Id = p.Id;
                brandNameObj.InventoryBrandName = p.BrandName;
                brandNameObj.BrandDiscription = p.BrandDiscription;
                brandNameObj.ContactInfo = p.ContactInfo;

                brabdNameList.Add(brandNameObj);
            }
            return brabdNameList;
        }

        public void SaveBrandCategory(BrandCategory _brandCategory)
        {
            var newBrandCategory = new INVENTORY_BRAND_CATEGORY
            {
                BrabdId = _brandCategory.BrabdId,
                CategoryName = _brandCategory.CategoryName,
            };
            datacontextObj.INVENTORY_BRAND_CATEGORY.Add(newBrandCategory);
            datacontextObj.SaveChanges();
        }

        public List<BrandCategory> LoadAllBrandCategory()
        {
            List<BrandCategory> brabdCategoryList = new List<BrandCategory>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.INVENTORY_BRAND_CATEGORY select j).Distinct())
            {
                BrandCategory brandCategoryObj = new BrandCategory();
                brandCategoryObj.Id = p.Id;
                brandCategoryObj.CategoryName = p.CategoryName;
                brandCategoryObj.BrabdId = p.BrabdId;
                brandCategoryObj.BrandName = p.INVENTORY_BRAND_NAME.BrandName;
                brandCategoryObj.BrandDiscription = p.INVENTORY_BRAND_NAME.BrandDiscription;
                brandCategoryObj.ContactInfo = p.INVENTORY_BRAND_NAME.ContactInfo;

                brabdCategoryList.Add(brandCategoryObj);
            }
            return brabdCategoryList;
        }

        public void SaveUnitType(UnitType _unittypeObj)
        {
            var newUnitType = new INVENTORY_UNIT_TYPE
            {
                UnitType = _unittypeObj.InventoryUnitType,
                UnitTypeDetails = _unittypeObj.UnitTypeDetails,

            };
            datacontextObj.INVENTORY_UNIT_TYPE.Add(newUnitType);
            datacontextObj.SaveChanges();
        }
        public List<UnitType> LoadAllUnitType()
        {
            List<UnitType> brabdUnitTypeList = new List<UnitType>();
            datacontextObj = new SIPIDBEntities();
            foreach (var p in (from j in datacontextObj.INVENTORY_UNIT_TYPE select j).Distinct())
            {
                UnitType brandUnitTypeObj = new UnitType();
                brandUnitTypeObj.Id = p.Id;
                brandUnitTypeObj.InventoryUnitType = p.UnitType;
                brandUnitTypeObj.UnitTypeDetails = p.UnitTypeDetails;

                brabdUnitTypeList.Add(brandUnitTypeObj);
            }
            return brabdUnitTypeList;
        }


       
    }
}
