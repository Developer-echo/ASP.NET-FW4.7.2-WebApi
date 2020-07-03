using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebEntity;
using WebHelper.LogHelper;
using WebOrm;

namespace WebApp.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        /// GetUserList
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<HttpResponseMessage> GetUserList()
        {
            try
            {
                using (var db = ConnOpen.GetInstance())
                {
                    var _user = await db.Queryable<UserInfo>().ToListAsync();
                    return Request.CreateResponse(HttpStatusCode.OK, _user);
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog("GetUserList 错误", ex);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
