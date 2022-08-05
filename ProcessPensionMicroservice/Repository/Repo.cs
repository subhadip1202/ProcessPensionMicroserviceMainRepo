using Newtonsoft.Json;
using ProcessPensionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ProcessPensionMicroservice.Repository
{
    public class Repo :IRepo
    {
        public dynamic getPensionByAadhar(int id )
        {
            var ids = Convert.ToString(id);
        
            List<PensionDetail> pensionInfo = new List<PensionDetail>();

            

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44396/api/pensionerdetail/");

                var responseTask = client.GetAsync(ids);
                responseTask.Wait();

                var result = responseTask.Result;
                
                if (result.IsSuccessStatusCode)
                {
                    dynamic PensionResponse = result.Content.ReadAsStringAsync().Result;


                    return PensionResponse;
      
                }
            else
            {
                return null;
            }

            
           
        }
    }
}



