using CDNVNONE;
using CDNVNONE.Repository;

namespace CDNVNCMS.Systems.Data
{
    [RegisterType(typeof(ISystemUOW),LifeTimeManager.Hierarchical)]
    public class SystemUOW:UnitOfWork<SystemContext>, ISystemUOW
    {
        public SystemUOW(SystemContext context):base(context){}
    }
}
