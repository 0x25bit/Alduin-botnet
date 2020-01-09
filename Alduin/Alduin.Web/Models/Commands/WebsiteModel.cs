using System.ComponentModel.DataAnnotations;

namespace Alduin.Web.Models
{
    public class WebsiteModel
    {
        [Display(Name = "Website Url")]
        public string Url { get; set; }
        [Display(Name = "Hidden")]
        public bool Hidde { get; set; }
        [Display(Name = "Cannot be Closed")]
        public bool Closed { get; set; }
    }
}
