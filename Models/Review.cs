using System.ComponentModel.DataAnnotations;

namespace restauranter.Models
{
    public class Review : BaseEntity
    {
        public int ReviewId { get; set; }

        [Display(Name= "Reviewer Name")]
        public string reviewer_name { get; set; }

        [Display(Name= "Restaurant Name")]
        public string restaurant_name { get; set; }

        [Display(Name= "Review")]
        public string review { get; set; }

        [Display(Name= "Rating")]
        public int rate { get; set; }
    }
}