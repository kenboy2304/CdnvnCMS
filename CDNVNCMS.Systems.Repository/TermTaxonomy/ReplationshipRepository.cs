using CDNVNCMS.Systems.Data;
using CDNVNONE;
using CDNVNONE.Repository;

namespace CDNVNCMS.Systems.Repository
{
    [RegisterType(typeof(IReplationshipRepository))]
    public class ReplationshipRepository:GenericRepository<TermRelationship,SystemContext>,IReplationshipRepository
    {
        public ReplationshipRepository(SystemContext context) : base(context){}
    }
}
