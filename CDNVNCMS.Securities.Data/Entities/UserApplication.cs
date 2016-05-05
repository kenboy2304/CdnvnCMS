using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data
{
    public class UserApplication:Entity<int>
    {
        [ForeignKey("Application")]
        public int AppId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public virtual User User { get; set; }
        public virtual Application Application { get; set; }
    }
}