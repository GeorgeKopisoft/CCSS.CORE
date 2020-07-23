using CCSS.CORE.MODEL;

namespace CCSS.CORE.REPOSITORY
{
    public class TechnologyRepository : EFCoreRepository<Technology, CCSSCOREContext>
    {
        public TechnologyRepository(CCSSCOREContext context) : base(context) 
        { 
        }
    }
}
