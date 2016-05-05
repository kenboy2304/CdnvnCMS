using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data
{
    public class Application:Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Publish { get; set; }
        public virtual List<UserApplication> AppUserses { get; set; }
        public virtual List<ApplicationMeta> ApplicationMetas { get; set; }
    }
}