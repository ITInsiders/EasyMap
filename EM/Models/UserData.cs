using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Models
{
    public class UserData
    {
        [Key]
        public string Login { get; set; }
        public DateTime DateOfRegistration { get; set; }

        [ForeignKey("Login")]
        public virtual User User { get; set; }
    }
}