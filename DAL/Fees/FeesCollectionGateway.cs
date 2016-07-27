using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITY.Fees;
using ENTITY.Report.Fees;


namespace DAL.Fees
{
    public class FeesCollectionGateway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();
        public List<ENTITY.Fees.FeesDetails> GetSemesterFeesDetails(ENTITY.Fees.FeesDetails obj)
        {
            List<FeesDetails> feesDetails = new List<FeesDetails>();
            foreach (var item in (from j in datacontextObj.STUDENTFEES
                                  where j.SemesterId == obj.SemesterId && j.StudentPkId == obj.StudentId && j.Year == obj.Year  
                                  select j).Distinct())
            {
                FeesDetails _obj = new FeesDetails();
                _obj.SemesterId = item.SemesterId;
                _obj.Year = item.Year;
                _obj.FeesDetailsId = item.FeesDetailsId;
                _obj.FeesDetailsName = item.FEESDETAIL.Name;
                _obj.Amount = item.Amount;
                _obj.Total = item.Total;
                _obj.StudentId = item.StudentPkId;
                _obj.DiscountAmount = item.DiscountAmount;
                _obj.DiscountPercent = item.DiscountPercent;
                _obj.TotalPayableAmount = item.TotalPayableAmount;
                _obj.PaidAmount = item.PaidAmount;
                _obj.DueAmount = item.DueAmount;
                _obj.PaidStatus = item.PaidStatus;
                feesDetails.Add(_obj);
            }
            return feesDetails;
        }

        public void SaveFeesCollectionDetails(FeesCollection obj)
        {
            var fees = new STUDENTFEESCOLLECTION
            {
                StudentPKId = obj.StudentId,
                SemesterId = obj.SemesterId,
                Year = obj.Year,
                ReceiveableAmount = obj.ReceiveAmount,
                ReceiveAmount = obj.ReceivableAmount,
                DueAmount = obj.DueAmount,
                ReceiveDate = obj.CollectionDate
            };
            datacontextObj.STUDENTFEESCOLLECTIONs.Add(fees);
            datacontextObj.SaveChanges();

            datacontextObj = new SIPIDBEntities();
            List<STUDENTFEE> entity = datacontextObj.STUDENTFEES.Where(it => it.StudentPkId == obj.StudentId && it.SemesterId == obj.SemesterId && it.Year == obj.Year).ToList();

            foreach (var item in entity)
            {
                if (entity != null)
                {

                    int? paid = 0;
                    int? due = 0;
                    if (item.PaidAmount != null)
                    {
                        paid = item.PaidAmount;
                    }
                    if (item.DueAmount != null)
                    {
                        due = item.DueAmount;
                    }

                    var product = datacontextObj.STUDENTFEES.First(it => it.StudentPkId == obj.StudentId && it.SemesterId == obj.SemesterId && it.Year == obj.Year);
                    product.PaidAmount = paid + obj.ReceiveAmount;
                    product.DueAmount = due - obj.ReceiveAmount;
                    datacontextObj.UpdateStudentPaymentAmount(obj.StudentId, obj.SemesterId, obj.Year, product.PaidAmount, product.DueAmount);
                    datacontextObj.SaveChanges();
                    break;
                }
            }
          
        }

        public List<ENTITY.Report.Fees.RStudentFees> GetCollectionReportDetails(FeesCollection obj)
        {
            List<RStudentFees> feesDetails = new List<RStudentFees>();
           var payment = datacontextObj.Student_Money_Receipt_Report(obj.StudentId, obj.SemesterId, obj.Year, obj.CollectionDate);

           foreach (var item in payment)
           {
               RStudentFees _obj = new RStudentFees();
               _obj.StudentRoll = Convert.ToString(item.AccadamicInfo_RollNo);
               _obj.InstituteName = item.CampusName;
               _obj.InstituteAddress = item.CampusAddress;
               _obj.StudentName = item.ApplicantName;
               _obj.Department = item.DepartmentName;
               _obj.Semester = item.SemesterNo;
               _obj.FeesDetailsName = item.Name;
               _obj.FeesDetailsAmount = item.Amount;
               _obj.ReceiveAmount = item.ReceiveAmount;
               _obj.ReceiveDate = item.ReceiveDate;
               feesDetails.Add(_obj);
           }
            return feesDetails;
        }

        public List<FeesCollection> GetAllCollection()
        {

            List<FeesCollection> feesCollectionDetails = new List<FeesCollection>();
            foreach (var item in datacontextObj.STUDENTFEESCOLLECTIONs)
            {
                FeesCollection _obj = new FeesCollection();
                _obj.Id = item.Id;
                _obj.StudentName = item.ADMISSIONINFO.ApplicantName;
                _obj.Semester = item.SEMESTER.SemesterNo;
                _obj.ReceiveAmount = item.ReceiveAmount;
                _obj.CollectionDate = item.ReceiveDate;
                _obj.Department = item.ADMISSIONINFO.SIPI_DEPARTMENT.SIPI_DepartmentName;
                _obj.SemesterId = item.SemesterId;
                _obj.Year = item.Year;
                _obj.StudentId = item.StudentPKId;
                _obj.CampusName = item.ADMISSIONINFO.CAMPUSINFO.CampusName;
                _obj.CampusId = item.ADMISSIONINFO.CAMPUSINFO.Id;

                feesCollectionDetails.Add(_obj);
            }
            return feesCollectionDetails;
        }

        public List<FeesCollection> GetCollection(DateTime startDate, DateTime endDate, int campus)
        {
            List<FeesCollection> feesCollectionDetails = new List<FeesCollection>();
            var query = from j in datacontextObj.STUDENTFEESCOLLECTIONs
                        where j.ReceiveDate >= startDate.Date && j.ReceiveDate <= endDate.Date && j.ADMISSIONINFO.CAMPUSINFO.Id == campus
                        select j;
            foreach (var item in query)
            {
                    FeesCollection _obj = new FeesCollection();
                    _obj.Id = item.Id;
                    _obj.StudentName = item.ADMISSIONINFO.ApplicantName;
                    _obj.Semester = item.SEMESTER.SemesterNo;
                    _obj.ReceiveAmount = item.ReceiveAmount;
                    _obj.CollectionDate = item.ReceiveDate;
                    _obj.Department = item.ADMISSIONINFO.SIPI_DEPARTMENT.SIPI_DepartmentName;
                    _obj.SemesterId = item.SemesterId;
                    _obj.Year = item.Year;
                    _obj.StudentId = item.StudentPKId;
                    _obj.CampusName = item.ADMISSIONINFO.CAMPUSINFO.CampusName;
                    _obj.CampusId = item.ADMISSIONINFO.CAMPUSINFO.Id;

                    feesCollectionDetails.Add(_obj);
            }
                return feesCollectionDetails;
          }
            
            
        }
    }

