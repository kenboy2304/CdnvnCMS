using CDNVNONE.Entities;
using System.Collections.Generic;

namespace CDNVNCMS.Systems.Data
{
    
    public class Term:Entity<int>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int TermGroup { get; set; }
    
        public virtual ICollection<TermMeta> TermMetas { get; set; }
        public virtual TermTaxonomy TermTaxonomy { get; set; }
    }
}
