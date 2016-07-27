using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{

    public class AdmissionOfficeGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void SaveAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            var newAdmissionOffice = new ADMISSIONOFFICE
            {
                OfficeName = _admissionOfficeObj.OfficeName,
                CampusId = _admissionOfficeObj.CampusId,

            };
            datacontextObj.ADMISSIONOFFICEs.Add(newAdmissionOffice);
            datacontextObj.SaveChanges();
        }

        public List<AdmissionOffice> LoadAllAdmissionOffice()
        {
            datacontextObj = new SIPIDBEntities();
            List<AdmissionOffice> departmentList = new List<AdmissionOffice>();

            foreach (var p in (from j in datacontextObj.ADMISSIONOFFICEs select j).Distinct())
            {

                AdmissionOffice admissionOfficeobj = new AdmissionOffice();
                admissionOfficeobj.Id = p.Id;
                admissionOfficeobj.OfficeName = p.OfficeName;
                admissionOfficeobj.CampusId = p.CampusId;
                admissionOfficeobj.OfficeAddress = p.CAMPUSINFO.CampusName;
                departmentList.Add(admissionOfficeobj);
            }

            return departmentList;
        }



        public void UpdateAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            var admissionOffice = datacontextObj.ADMISSIONOFFICEs.First(c => c.Id == _admissionOfficeObj.Id);
            admissionOffice.CampusId = _admissionOfficeObj.CampusId;
            admissionOffice.OfficeName = _admissionOfficeObj.OfficeName;
            datacontextObj.SaveChanges();
        }

        public void DeleteAdmissionOffice(AdmissionOffice _admissionOfficeObj)
        {
            ADMISSIONOFFICE admissionoffice = datacontextObj.ADMISSIONOFFICEs.First(c => c.Id == _admissionOfficeObj.Id);
            datacontextObj.ADMISSIONOFFICEs.Remove(admissionoffice);
            datacontextObj.SaveChanges();
        }
    }
  }

