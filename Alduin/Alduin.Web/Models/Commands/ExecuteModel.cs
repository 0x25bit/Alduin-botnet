using System.ComponentModel.DataAnnotations;

namespace Alduin.Web.Models
{
    public class ExecuteModel
    {
        [Display(Name = "File direct link")]
        public string Url { get; set; }
        [Display(Name = "File new name")]
        public string Name { get; set; }
        [Display(Name = "Run it too ?")]
        public bool Run { get; set; }
    }
}
