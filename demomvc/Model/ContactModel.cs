using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demomvc.Model
{
    public class ContactModel
    {   
        [Display(Name="Name:")]
         public string Name { get; set; }
        
        [Display(Name = "Mail:")]
        [EmailAddress(ErrorMessage = "*")]
        public string Mail { get; set; }
       
        [Display(Name = "Subject:")]
        public string Subject{ get; set; }

        [Display(Name = "Message:")]
        public string Message { get; set; }
        

        
    }
}