using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnicalMVCApp.Models
{
    public class User
    {
        public int userid { get; set; }
        [Required]
        public string name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DOB { get; set; }
        public string Designation { get; set; }
        public string Skills { get; set; }
       

    }
    
}