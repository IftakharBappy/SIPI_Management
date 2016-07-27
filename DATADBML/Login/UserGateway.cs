using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.Login;

namespace DATADBML.Login
{
   public class UserGateway
    {
        private SIPLDBMLDataContext hasanMainDataContectObj;
        public EUser GetAllInfoforSingleUser(EUser anUser)
        {
            hasanMainDataContectObj = new SIPLDBMLDataContext();
            var query = from j in hasanMainDataContectObj.USERs
                        where j.USER_NAME == anUser.UserName.ToLower()
                        select j;
            foreach (var user in query)
            {
                anUser.UserId = user.USER_ID;
                anUser.UserName = user.USER_NAME;
                anUser.UserPassword = user.USER_PASSWORD;
                anUser.UserGroupId = user.USER_GROUP_ID;
                anUser.UserGroupName = user.USER_GROUP.GROUP_NAME;
            }
            return anUser;
        }

        public bool DoesExistUserinLoginMode(EUser anUser)
        {
            hasanMainDataContectObj = new SIPLDBMLDataContext();
            return (hasanMainDataContectObj.USERs.Any(user => user.USER_NAME.Equals(anUser.UserName) && user.USER_PASSWORD.Equals(anUser.UserPassword)));
        }
    }
}
