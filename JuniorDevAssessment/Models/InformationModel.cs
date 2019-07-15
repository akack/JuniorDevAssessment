using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuniorDevAssessment.Models
{
    public class InformationModel
    {
        public int _id { get; set; }
        public string Certificate_Name { get; set; }
        public string Group { get; set; }
        public string Issued_date { get; set; }
        public string Expiry_date { get; set; }
        public string Status { get; set; }
    }
}