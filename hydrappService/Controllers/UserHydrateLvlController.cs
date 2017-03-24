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
    public class UserHydrateLvlController : TableController<UserHydrateLvl>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            hydrappContext context = new hydrappContext();
            DomainManager = new EntityDomainManager<UserHydrateLvl>(context, Request);
        }

        // GET tables/UserHydrateLvl
        public IQueryable<UserHydrateLvl> GetAllUserHydrateLvl()
        {
            return Query(); 
        }

        // GET tables/UserHydrateLvl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserHydrateLvl> GetUserHydrateLvl(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserHydrateLvl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserHydrateLvl> PatchUserHydrateLvl(string id, Delta<UserHydrateLvl> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/UserHydrateLvl
        public async Task<IHttpActionResult> PostUserHydrateLvl(UserHydrateLvl item)
        {
            UserHydrateLvl current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserHydrateLvl/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserHydrateLvl(string id)
        {
             return DeleteAsync(id);
        }
    }
}
