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
    public class BandEntryController : TableController<BandEntry>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            hydrappContext context = new hydrappContext();
            DomainManager = new EntityDomainManager<BandEntry>(context, Request);
        }

        // GET tables/BandEntry
        public IQueryable<BandEntry> GetAllBandEntry()
        {
            return Query(); 
        }

        // GET tables/BandEntry/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<BandEntry> GetBandEntry(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/BandEntry/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<BandEntry> PatchBandEntry(string id, Delta<BandEntry> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/BandEntry
        public async Task<IHttpActionResult> PostBandEntry(BandEntry item)
        {
            BandEntry current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/BandEntry/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBandEntry(string id)
        {
             return DeleteAsync(id);
        }
    }
}
