using CDNVNONE.Entities;

namespace CDNVNCMS.Systems.Data
{
    
    public class TermMeta:Entity<int>
    {
        public int TermId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public virtual Term Term { get; set; }
    }
}
