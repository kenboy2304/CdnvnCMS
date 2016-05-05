using CDNVNCMS.Systems.Data;
using CDNVNONE;
using CDNVNONE.Repository;

namespace CDNVNCMS.Systems.Repository
{
    [RegisterType(typeof(ITaxonomyRepository))]
    public class TaxonomyRepository: GenericRepository<TermTaxonomy,SystemContext>,ITaxonomyRepository
    {
        public TaxonomyRepository(SystemContext context) : base(context){}
    }
}
