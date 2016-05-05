using CDNVNONE;
using CDNVNONE.Repository;

namespace CDNVNCMS.Securities.Data
{
    [RegisterType(typeof(ISecurityUOW),LifeTimeManager.Hierarchical)]
    public class SercurityUOW:UnitOfWork<SecurityContext>, ISecurityUOW
    {
        public SercurityUOW(SecurityContext context):base(context){}
    }
}
