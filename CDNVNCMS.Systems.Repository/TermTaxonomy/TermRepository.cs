using CDNVNCMS.Systems.Data;
using CDNVNONE;
using CDNVNONE.Repository;

namespace CDNVNCMS.Systems.Repository
{
    [RegisterType(typeof(ITermRepository))]
    public class TermRepository:GenericRepository<Term,SystemContext>,ITermRepository
    {
        public TermRepository(SystemContext context) : base(context){}
    }
}
