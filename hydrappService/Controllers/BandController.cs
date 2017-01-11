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
    public class BandController : TableController<Band>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            hydrappContext context = new hydrappContext();
            DomainManager = new EntityDomainManager<Band>(context, Request);
        }

        // GET tables/Band
        public IQueryable<Band> GetAllBand()
        {
            return Query(); 
        }

        // GET tables/Band/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Band> GetBand(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Band/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Band> PatchBand(string id, Delta<Band> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Band
        public async Task<IHttpActionResult> PostBand(Band item)
        {
            Band current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Band/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBand(string id)
        {
             return DeleteAsync(id);
        }
    }
}
