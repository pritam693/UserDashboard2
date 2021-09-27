using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserDashboard2.Models
{
    [Table("CustomerInfo")]
    public class customerInfo
    {
        [Key]
        public int CustId { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool TrialUser { get; set; }

        public string Username { get; set; }
        [DisplayName("Customer")]
        public string ListOfCustomers { get; set; }
        [DisplayName("Global Gleason Admin")]
        public bool globalGleasonAdmin { get; set; }
        [DisplayName("User")]
        public bool user { get; set; }
        [DisplayName("Customer Admin")]
        public bool customerAdmin { get; set; }
        [DisplayName("Gleason Regional Sales Manager")]
        public bool rsm { get; set; }
        [DisplayName("Gleason Internal Sales")]
        public bool gleasonInternalSales { get; set; }
        [DisplayName("Gleason Engineer/Service Engineer")]
        public bool sE { get; set; }       
        [NotMapped]
        public string selectedEditText { get; set; }

    }
  
}