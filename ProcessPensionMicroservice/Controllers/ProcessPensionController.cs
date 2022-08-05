using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessPensionMicroservice.Data;
using ProcessPensionMicroservice.Models;
using ProcessPensionMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Controllers
{
    [Route("api/processpension")]
    [ApiController]
    public class ProcessPensionController : ControllerBase
    {

        private readonly IRepo _irepo;

        private readonly MThreePensionDbContext _pensionDbContext;
        public ProcessPensionController(IRepo irepo, MThreePensionDbContext pensionDbContext)
           {
               _irepo = irepo;
               _pensionDbContext = pensionDbContext;
           }
       
        [HttpPost("{id:int}")]

        public IActionResult Pension( int id )
        {

            dynamic penemp =  _irepo.getPensionByAadhar(id);
            PensionerDetailModel Obj = JsonSerializer.Deserialize<PensionerDetailModel>(penemp);

            PensionDetail person = new PensionDetail { };

            if (penemp != null)
            {
   
                if (Obj.pensiontype == "self")
                {
                    person.aadharno = id;
                    person.PensionAmount = (80 * (Convert.ToInt32(Obj.salaryearned)) / 100) + (Convert.ToInt32(Obj.allowances));
                }
                else
                {
                    person.aadharno = id;
                    person.PensionAmount = (80 * (Convert.ToInt32(Obj.salaryearned)) / 100) + (Convert.ToInt32(Obj.allowances));

                }
                if (Obj.banktype == "public")
                {   
                    person.aadharno = id;
                    person.BankServiceCharge = 500;
                }
                else
                {
                    person.aadharno = id;
                    person.BankServiceCharge = 550;
                }


                var checkData = _pensionDbContext
                                .pensionDetails
                                .Where(u => u.aadharno == id)
                                .Select(u => u.aadharno)
                                .SingleOrDefault();
                if (checkData != id)
                {

                this._pensionDbContext.pensionDetails.Add(person);
                this._pensionDbContext.SaveChanges();
                }



                return Ok(person);
            }
            else
            {
                return BadRequest("Invalid Data");
            }
        }


    }
}
