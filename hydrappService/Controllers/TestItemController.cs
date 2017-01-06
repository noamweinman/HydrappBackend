using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using hydrappService.DataObjects;
using hydrappService.Models;

namespace hydrappService.Controllers
{
    public class TestItemController : TableController<TestItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            hydrappContext context = new hydrappContext();
            DomainManager = new EntityDomainManager<TestItem>(context, Request);
        }

        // GET tables/TestItem
        public IQueryable<TestItem> GetAllTestItem()
        {
            return Query(); 
        }

        // GET tables/TestItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TestItem> GetTestItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TestItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TestItem> PatchTestItem(string id, Delta<TestItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/TestItem
        public async Task<IHttpActionResult> PostTestItem(TestItem item)
        {
            TestItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TestItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTestItem(string id)
        {
             return DeleteAsync(id);
        }
    }
}
