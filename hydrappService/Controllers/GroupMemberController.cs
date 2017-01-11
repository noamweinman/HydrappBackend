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
    public class GroupMemberController : TableController<GroupMember>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            hydrappContext context = new hydrappContext();
            DomainManager = new EntityDomainManager<GroupMember>(context, Request);
        }

        // GET tables/GroupMember
        public IQueryable<GroupMember> GetAllGroupMember()
        {
            return Query(); 
        }

        // GET tables/GroupMember/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<GroupMember> GetGroupMember(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/GroupMember/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<GroupMember> PatchGroupMember(string id, Delta<GroupMember> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/GroupMember
        public async Task<IHttpActionResult> PostGroupMember(GroupMember item)
        {
            GroupMember current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/GroupMember/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteGroupMember(string id)
        {
             return DeleteAsync(id);
        }
    }
}
