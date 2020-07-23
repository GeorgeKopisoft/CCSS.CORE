using CCSS.CORE.MODEL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCSS.CORE.REPOSITORY
{
    public class TechnologyService
    {
        private readonly TechnologyRepository repository;

        public TechnologyService(CCSSCOREContext context)
        {
            repository = new TechnologyRepository(context);
        }

        public async Task<Technology> Add(Technology technology)
        {
            try
            {
                technology = await repository.Add(technology);
            }
            catch (Exception)
            {
                technology = null;
            }
            return technology;
        }

        public async Task<Technology> Get(Technology technology)
        {
            try
            {
                technology = await repository.Get(technology.Id);
            }
            catch (Exception)
            {
                technology = null;
            }
            return technology;
        }

        public async Task<IList<Technology>> GetAll()
        {
            IList<Technology> list;
            try
            {
                list = await repository.GetAll();
            }
            catch (Exception)
            {
                list = null;
            }
            return list;
        }

        public async Task<Technology> Update(Technology technology)
        {
            try
            {
                technology = await repository.Update(technology);
            }
            catch (Exception)
            {
                technology = null;
            }
            return technology;
        }

        public async Task<Technology> Delete(Technology technology)
        {
            try
            {
                technology = await repository.Delete(technology.Id);
            }
            catch (Exception)
            {
                technology = null;
            }
            return technology;
        }
    }
}
