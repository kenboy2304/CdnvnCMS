using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data
{
    public class ApplicationMeta:Entity<int>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
