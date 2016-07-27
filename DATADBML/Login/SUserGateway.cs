using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.Login;

namespace DATADBML.Login
{
   public class SUserGateway
    {
        private SIPLDBMLDataContext _hasanSecurityDataContextObj;
        public bool SaveUserInfo(ESUser anUser)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            var newUser = new USER()
            {
                USER_NAME = anUser.UserName,
                USER_PASSWORD = anUser.UserPassword,
                USER_GROUP_ID = anUser.UserGroupId
            };
            _hasanSecurityDataContextObj.USERs.InsertOnSubmit(newUser);
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }
        public bool DoesExistUserinSaveMode(string userName)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            return (_hasanSecurityDataContextObj.USERs.Any(user => user.USER_NAME.Equals(userName)));
        }
        public bool UpdateUserInfo(ESUser anUser)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            var user = _hasanSecurityDataContextObj.USERs.FirstOrDefault(u => u.USER_ID == anUser.UserId);
            user.USER_NAME = anUser.UserName;
            user.USER_PASSWORD = anUser.UserPassword;
            user.USER_GROUP_ID = anUser.UserGroupId;
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }
        public bool DeleteUser(long userId)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            USER userObj = _hasanSecurityDataContextObj.USERs.FirstOrDefault(u => u.USER_ID == userId);
            _hasanSecurityDataContextObj.USERs.DeleteOnSubmit(userObj);
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }
        public List<ESUser> GetAllUser()
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            List<ESUser> listUser = new List<ESUser>();
            foreach (var user in _hasanSecurityDataContextObj.USERs)
            {
                ESUser anUser = new ESUser();
                anUser.UserId = user.USER_ID;
                anUser.UserName = user.USER_NAME;
                anUser.UserPassword = user.USER_PASSWORD;
                anUser.UserGroupId = user.USER_GROUP_ID;
                anUser.UserGroupName = user.USER_GROUP.GROUP_NAME;
                listUser.Add(anUser);
            }
            return listUser;
        }
        public ESUser GetAllInfoforSingleUser(ESUser anUser)
        {

            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            var query = from j in _hasanSecurityDataContextObj.USERs where j.USER_NAME == anUser.UserName.ToLower() select j;
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
        public bool UpdateUserPassword(ESUser anUser)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            var user = _hasanSecurityDataContextObj.USERs.FirstOrDefault(u => u.USER_ID == anUser.UserId);
            user.USER_PASSWORD = anUser.UserPassword;
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }
        /******************Login Purpose*****************/
        public bool DoesExistUserinLoginMode(ESUser anUser)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            return (_hasanSecurityDataContextObj.USERs.Any(user => user.USER_NAME.Equals(anUser.UserName) && user.USER_PASSWORD.Equals(anUser.UserPassword)));
        }
    }
}
