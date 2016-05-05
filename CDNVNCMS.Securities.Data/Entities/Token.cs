using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data.Entities
{
    public class Token:Entity<int>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string AuthToken { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }

    }
}
