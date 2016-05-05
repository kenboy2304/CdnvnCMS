
using CDNVNONE.Entities;

namespace CDNVNCMS.Systems.Data
{
    public class Option:Entity<int>
    {
        public int ApplicationId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool AutoLoad { get; set; }
    }
}
