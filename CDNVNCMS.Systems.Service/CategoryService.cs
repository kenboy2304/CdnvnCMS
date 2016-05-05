using CDNVNCMS.Systems.Data;
using CDNVNCMS.Systems.Repository;
using CDNVNONE;
using CDNVNONE.Service;

namespace CDNVNCMS.Systems.Service
{
    [RegisterType(typeof(ICategoryService))]
    public class CategoryService:EntityService<TermTaxonomy,SystemContext>, ICategoryService
    {
        public CategoryService(ISystemUOW unitOfWork, ITaxonomyRepository repository) : base(unitOfWork, repository)
        {}

        public void Create(int appId,string name, string desc, string slug, int parentId)
        {
            var entity = new TermTaxonomy
            {
                ApplicationId = appId,
                Taxonomy = "Category",
                ParentId = parentId,
                Term = new Term
                {
                    Name = name,
                    Slug = slug,
                },              
            };
            base.Create(entity);
        }
        public override void Create(TermTaxonomy entity)
        {
            entity.Taxonomy = "Category";
            base.Create(entity);
        }
        
    }
}
