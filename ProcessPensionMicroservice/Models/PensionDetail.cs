using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Models
{
    public class PensionDetail
    {

        public PensionDetail() { }
        [Required]
        [Key]
        public long aadharno { get; set; }

        [Required]
        public long PensionAmount{ get; set; }
        [Required]
        public long BankServiceCharge { get; set; }
    }
}
