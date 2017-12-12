using System;
using System.ComponentModel.DataAnnotations;

namespace restauranter.Models
{
    public abstract class BaseEntity
    {
        [Display(Name= "Date Of Visit")]
        public DateTime created_at {get; set; }
        public DateTime updated_at {get; set; }
      
    }
}