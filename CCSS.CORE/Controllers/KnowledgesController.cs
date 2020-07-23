using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CCSS.CORE.MODEL;
using CCSS.CORE.SERVICE;
using CCSS.CORE.REPOSITORY;

namespace CCSS.CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnowledgesController : ControllerBase
    {
        private readonly KnowledgeService service;

        public KnowledgesController(CCSSCOREContext context)
        {
            service = new KnowledgeService(context);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Knowledge>>> GetKnowledge()
        {
            var response = await service.GetAll();
            return StatusCode(200, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Knowledge>> GetKnowledge(int id)
        {
            var request = new Knowledge() { Id = id };
            var response = await service.Get(request);
            return StatusCode(200, response);
        }

        [HttpPatch]
        public async Task<ActionResult<Knowledge>> PutKnowledge(Knowledge knowledge)
        {
            var response = await service.Update(knowledge);
            return StatusCode(200, response);
        }

        [HttpPost]
        public async Task<ActionResult<Knowledge>> PostKnowledge(Knowledge knowledge)
        {
            var response = await service.Add(knowledge);
            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Knowledge>> DeleteKnowledge(int id)
        {
            var request = new Knowledge() { Id = id };
            var response = await service.Delete(request);
            return StatusCode(200, response);
        }

    }
}
