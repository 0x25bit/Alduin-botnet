using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alduin.Web.Models
{
    public class ChangePasswordModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Old-Password")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New-password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string RePassword { get; set; }
    }
}
