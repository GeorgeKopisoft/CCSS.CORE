using CCSS.CORE.MODEL;
using CCSS.CORE.REPOSITORY;
using CCSS.CORE.UTILS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCSS.CORE.SERVICE
{
    public class KnowledgeService
    {
        private readonly KnowledgeRepository repository;
        private readonly TechnologyRepository techRepository;

        public KnowledgeService(CCSSCOREContext context)
        {
            repository = new KnowledgeRepository(context);
            techRepository = new TechnologyRepository(context);
        }

        public async Task<Knowledge> Add(Knowledge knowledge)
        {
            try
            {
                knowledge = await repository.Add(knowledge);
            }
            catch (Exception ex)
            {
                NLog.Write(ex);
                knowledge = null;
            }
            return knowledge;
        }

        public async Task<Knowledge> Get(Knowledge knowledge)
        {
            try
            {
                knowledge = await repository.Get(knowledge.Id);
                var tech = await techRepository.Get(knowledge.TechId);
                knowledge.Tech = tech;
            }
            catch (Exception ex)
            {
                NLog.Write(ex);
                knowledge = null;
            }
            return knowledge;
        }

        public async Task<IEnumerable<Knowledge>> GetAll()
        {
            IEnumerable<Knowledge> list;
            try
            {
               list = await repository.GetAll();
                foreach (var item in list)
                {
                    var tech = await techRepository.Get(item.TechId);
                    item.Tech = tech;
                }
            }
            catch (Exception ex)
            {
                NLog.Write(ex);
                list = null;
            }
            return list;
        }

        public async Task<Knowledge> Update(Knowledge knowledge)
        {
            try
            {
                knowledge = await repository.Update(knowledge);
            }
            catch (Exception ex)
            {
                NLog.Write(ex);
                knowledge = null;
            }
            return knowledge;
        }

        public async Task<Knowledge> Delete(Knowledge knowledge)
        {
            try
            {
                knowledge = await repository.Delete(knowledge.Id);
            }
            catch (Exception ex)
            {
                NLog.Write(ex);
                knowledge = null;
            }
            return knowledge;
        }

    }
}
