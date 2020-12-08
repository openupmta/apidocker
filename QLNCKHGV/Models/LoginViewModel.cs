using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QLNCKHGV.Models
{
    public class LoginViewModel
    {
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }

}