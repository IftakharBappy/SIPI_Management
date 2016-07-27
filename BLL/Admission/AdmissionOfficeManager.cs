using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
   public class AdmissionOfficeManager
    {
       AdmissionOfficeGetway admissionOfficeGetwayobj = new AdmissionOfficeGetway();

        public void SaveAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            admissionOfficeGetwayobj.SaveAdmissionOffice(_admissionOfficeObj);
        }
        public List<AdmissionOffice> LoadAllAdmissionOffice()
        {
            return admissionOfficeGetwayobj.LoadAllAdmissionOffice();
            
        }
        //public void DeleteOffice(AdmissionOffice _admissionOfficeObj)
        //{
        //    admissionOfficeGetwayobj.DeleteOffice(_admissionOfficeObj);
        //}



        public void UpdateAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            admissionOfficeGetwayobj.UpdateAdmissionOffice(_admissionOfficeObj);
        }
        public void DeleteAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            admissionOfficeGetwayobj.DeleteAdmissionOffice(_admissionOfficeObj);
        }
    }
}
