using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Fees
{
    public class FeesDetails : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string FeesName { get; set;}
      
        public int? StudentId { get; set; }
        public int? Year { get; set; }
        public int SemesterId { get; set; }


        public int? FeesDetailsId { get; set; }
        public int? CampusId { get; set; }

        public int? Amount { get; set; }

        public int? Total { get; set; }

        public int? DiscountAmount { get; set; }

        public int? DiscountPercent { get; set; }

        public int? TotalPayableAmount { get; set; }

        public int? DueAmount { get; set; }

        public string PaidStatus { get; set; }

        public string FeesDetailsName { get; set; }

        public int? PaidAmount { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(System.String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public int feesAmount { get; set; }
    
        public int FeesAmount
        {
            get
            {
                return this.feesAmount;
            }

            set
            {
                if (value != this.feesAmount)
                {
                    this.feesAmount = value;
                    NotifyPropertyChanged("FeesAmount");
                }
            }
        }

     
    }
}
