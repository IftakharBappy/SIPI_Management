using DATA;
using ENTITY.Admission;
using ENTITY.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Fees
{
    public class FeesSetupGetway
    {
        SIPIDBEntities dataContext = new SIPIDBEntities();

        public void SaveFees(List<FeesSetup> _feesSetupListObj)
        {
            int? department = 0, semester = 0,campus = 0, intYear=0;
            string year = "";
            // Save Fees Information
            foreach (FeesSetup item in _feesSetupListObj)
            {
                department = item.DepartmentId;
                semester = item.SemesterId;
                year = item.Year.ToString();
                campus = item.CampusId;
                intYear = item.Year;
                var newSemester = new FEESSETUP
                {
                    DepartmentId = item.DepartmentId,
                    SemesterId = item.SemesterId,
                    Year = item.Year,
                    FeesDetailsId = item.FeesDetailsId,
                    Amount = item.Amount,
                    CampusId=item.CampusId,
                    Total = item.Total
                };
                dataContext.FEESSETUPs.Add(newSemester);
                dataContext.SaveChanges();
                
            }
            // Get All Student Information
            List<StudentInfo> studentInfoList = new List<StudentInfo>();
            foreach (var p in (from j in dataContext.ADMISSIONINFOes
                               where j.DepartmentId == department && j.CampusId == campus && j.AccadamicYear == year
                               select j).Distinct())
            {
                StudentInfo studentInfo = new StudentInfo();
                studentInfo.Id = p.Id;
                studentInfoList.Add(studentInfo);
            }

            // Get Fees Details
            List<FeesSetup> feesList = new List<FeesSetup>();
            foreach (var p in (from j in dataContext.FEESSETUPs
                               where j.DepartmentId == department && j.Year == intYear && j.CampusId == campus && j.SemesterId == semester
                               select j).Distinct())
            {
                FeesSetup feesDetails = new FeesSetup();
                feesDetails.DepartmentId = p.DepartmentId;
                feesDetails.SemesterId = p.SemesterId;
                feesDetails.Year = p.Year;
                feesDetails.FeesDetailsId = p.FeesDetailsId;
                feesDetails.Amount = p.Amount;
                feesDetails.Total = p.Total;
                feesList.Add(feesDetails);
            }

            foreach (StudentInfo student in studentInfoList)
            {
                foreach (FeesSetup item in feesList)
                {
                    var fee = new STUDENTFEE
                    {
                        DepartmentId = item.DepartmentId,
                        SemesterId = item.SemesterId,
                        Year = item.Year,
                        FeesDetailsId = item.FeesDetailsId,
                        Amount = item.Amount,
                        Total = item.Total,
                        StudentPkId = student.Id,
                        DiscountAmount = 0,
                        DiscountPercent = 0,
                        PaidAmount = 0,
                        TotalPayableAmount = item.Total,
                        DueAmount = item.Total,
                        PaidStatus = "Unpaid"
                    };
                    dataContext.STUDENTFEES.Add(fee);
                    dataContext.SaveChanges();

                }
            }

           

        }
    }
}
