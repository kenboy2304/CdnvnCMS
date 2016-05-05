using CDNVNCMS.Systems.Data;
using CDNVNCMS.Systems.Repository;
using CDNVNONE;
using CDNVNONE.Service;

namespace CDNVNCMS.Systems.Service
{
    [RegisterType(typeof(ITaxonomyService))]
    public class TaxonomyService:EntityService<TermTaxonomy,SystemContext>, ITaxonomyService
    {
        public TaxonomyService(ISystemUOW unitOfWork, ITaxonomyRepository repository) : base(unitOfWork, repository){}
    }
}
