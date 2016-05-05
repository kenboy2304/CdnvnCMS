using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data
{
    public class UserMeta:Entity<int>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
