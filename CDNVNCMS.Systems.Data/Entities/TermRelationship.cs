
using System.ComponentModel.DataAnnotations.Schema;
using CDNVNONE.Entities;

namespace CDNVNCMS.Systems.Data
{
    public partial class TermRelationship:Entity<int>
    {
        public int ObjectId { get; set; }
        public int TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
        [ForeignKey("ObjectId")]
        public virtual Post Object { get; set; }
        [ForeignKey("TermTaxonomyId")]
        public virtual TermTaxonomy TermTaxonomy { get; set; }
    }
}
