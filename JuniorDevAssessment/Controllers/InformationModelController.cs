using JuniorDevAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace JuniorDevAssessment.Controllers
{
    public class InformationModelController : ApiController
    {
        string issued_date = "2015, 12, 25";
        string expiry_date = "2015, 12, 25";
        private InformationModel[] informationModels = new InformationModel[]
        {
            new InformationModel { _id = 1, Certificate_Name= "Basic Slinging Training", Group="", Issued_date = "07 Jun 2019", Expiry_date = "07 Jun 2020", Status ="Active" },
            new InformationModel { _id = 2, Certificate_Name= "Bestuuders Lisensie", Group="Vehicle Licences", Issued_date = "07 Jul 2015", Expiry_date = "07 Jul 2020", Status ="Active" },
            new InformationModel { _id = 3, Certificate_Name= "Fire Team Training", Group="", Issued_date = "22 Dec 2017", Expiry_date = "22 Dec 202", Status ="Active" },
            new InformationModel { _id = 4, Certificate_Name= "First Aider Training", Group="", Issued_date = "09 Nov 2017", Expiry_date = "09 Nov 2019", Status ="Active" },
            new InformationModel { _id = 5, Certificate_Name= "Induction", Group="", Issued_date = "27 Feb 2019", Expiry_date = "27 Feb 202", Status ="Active" },
            new InformationModel { _id = 6, Certificate_Name= "Induction - Zulu", Group="", Issued_date = "13 Aug 2018", Expiry_date = "13 Aug 2019", Status ="Active" },
            new InformationModel { _id = 7, Certificate_Name= "Medical", Group="", Issued_date = "05 Aug 2009", Expiry_date = "05 Aug 2010", Status ="Expired" }
        };
        // GET: api/InformationModel
        [ResponseType(typeof(IEnumerable<InformationModel>))]
        public IEnumerable<InformationModel> Get()
        {
            return informationModels;
        }

        // GET: api/InformationModel/5
        public IHttpActionResult Get(int id)
        {
            var informationRecord = informationModels.FirstOrDefault((p) => p._id == id);
            if(informationRecord == null)
            {
                return NotFound();
            }
            return Ok(informationRecord);
        }

        // POST: api/InformationModel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/InformationModel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/InformationModel/5
        public void Delete(int id)
        {
        }
    }
}
