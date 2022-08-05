using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Models
{
    public class PensionerDetailModel
    {
        public long aadharno { get; set; }
        public string pan { get; set; }

        public string name { get; set; }
        public string dob { get; set; }
        public long salaryearned { get; set; }
        public long allowances { get; set; }
        public string pensiontype { get; set; }
        public string accno { get; set; }
        public string bankname { get; set; }
        public string banktype { get; set; }
    }
}
