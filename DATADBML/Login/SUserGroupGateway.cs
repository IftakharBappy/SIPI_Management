using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.Login;

namespace DATADBML.Login
{
   public class SUserGroupGateway
    {
        private SIPLDBMLDataContext _hasanSecurityDataContextObj;
        public bool SaveUserGroup(ESUserGroup anEuserGroup)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            var newUserGroup = new USER_GROUP
            {
                GROUP_NAME = anEuserGroup.GroupName
            };
            _hasanSecurityDataContextObj.USER_GROUPs.InsertOnSubmit(newUserGroup);
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }

        public bool UpdateUserGroup(ESUserGroup anUserGroup)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            var group = _hasanSecurityDataContextObj.USER_GROUPs.FirstOrDefault(u => u.GROUP_ID == anUserGroup.Id);
            group.GROUP_NAME = anUserGroup.GroupName;
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }

        public bool DeleteUserGroup(long userGroupId)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            USER_GROUP userGroupObj = _hasanSecurityDataContextObj.USER_GROUPs.FirstOrDefault(u => u.GROUP_ID == userGroupId);
            _hasanSecurityDataContextObj.USER_GROUPs.DeleteOnSubmit(userGroupObj);
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }

        public List<ESUserGroup> GetAllUserGroup()
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            List<ESUserGroup> listUserGroup = new List<ESUserGroup>();
            var query = from j in _hasanSecurityDataContextObj.USER_GROUPs select j;
            foreach (var userGroup in query)
            {
                ESUserGroup anUserGroup = new ESUserGroup();
                anUserGroup.Id = userGroup.GROUP_ID;
                anUserGroup.GroupName = userGroup.GROUP_NAME;
                listUserGroup.Add(anUserGroup);
            }
            return listUserGroup;
        }

        public bool DoesExistAnyUserUnderThisGroup(long groupId)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            return (_hasanSecurityDataContextObj.USERs.Any(u => u.USER_GROUP_ID == groupId));
        }
    }
}
