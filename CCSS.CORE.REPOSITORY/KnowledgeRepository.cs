using CCSS.CORE.MODEL;

namespace CCSS.CORE.REPOSITORY
{
    public class KnowledgeRepository : EFCoreRepository<Knowledge, CCSSCOREContext>
    {
        CCSSCOREContext context;

        public KnowledgeRepository(CCSSCOREContext context) : base (context)
        {
        }

    }
}
