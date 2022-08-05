using ProcessPensionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Repository
{
   public interface IRepo
    {
        dynamic getPensionByAadhar(int id );
    }
}
