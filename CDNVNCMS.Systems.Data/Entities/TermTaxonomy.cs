using System.ComponentModel.DataAnnotations.Schema;
using CDNVNONE.Entities;
using System;
using System.Collections.Generic;
namespace CDNVNCMS.Systems.Data
{
    public partial class TermTaxonomy:Entity<int>
    {
        public int ApplicationId { get; set; }
        public string Taxonomy { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int Count { get; set; }
        public virtual ICollection<TermRelationship> TermRelationships { get; set; }
        public virtual Term Term { get; set; }
        public virtual ICollection<TermTaxonomy> Children { get; set; }
        [ForeignKey("ParentId")]
        public virtual TermTaxonomy Parent { get; set; }
    }
}
