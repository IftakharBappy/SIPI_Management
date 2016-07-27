using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY.Login;

namespace DATADBML.Login
{
   public class SModulePermissionGateway
    {
        private SIPLDBMLDataContext _hasanSecurityDataContextObj;
        public bool SaveModulePermission(ESModulePermission objEsModPer)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            var Module = new MODULE_PERMISSION
            {
                MODULE_NAME = objEsModPer.ModuleName,
                USER_GROUP_ID = objEsModPer.UserGroupId
            };
            _hasanSecurityDataContextObj.MODULE_PERMISSIONs.InsertOnSubmit(Module);
            _hasanSecurityDataContextObj.SubmitChanges();
            return true;
        }
        public bool DeleteModulePermission(long userGroupId)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            var module = from j in _hasanSecurityDataContextObj.MODULE_PERMISSIONs where j.USER_GROUP_ID == userGroupId select j;
            if (module != null)
            {
                _hasanSecurityDataContextObj.MODULE_PERMISSIONs.DeleteAllOnSubmit(module);
                _hasanSecurityDataContextObj.SubmitChanges();
                return true;
            }
            return false;
        }
        public List<ESModulePermission> GetPermittedModule(long groupId)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            List<ESModulePermission> listPM = new List<ESModulePermission>();

            foreach (var module in (from j in _hasanSecurityDataContextObj.MODULE_PERMISSIONs where j.USER_GROUP_ID == groupId select j))
            {
                ESModulePermission objEMPerm = new ESModulePermission();
                objEMPerm.Id = module.ID;
                objEMPerm.ModuleName = module.MODULE_NAME;
                objEMPerm.UserGroupId = Convert.ToInt64(module.USER_GROUP_ID);
                objEMPerm.UserGroupName = module.USER_GROUP.GROUP_NAME;
                listPM.Add(objEMPerm);
            }
            return listPM;
        }
        public List<string> GetNOTPermittedModule(List<string> listAvailablemodule, List<string> listPermittedModule)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();
            List<string> listnotPM = new List<string>();

            var query = from module in ((from avail in listAvailablemodule select avail).Union(from permitted in listPermittedModule select permitted)).Except(from peMod in listPermittedModule select peMod) select module;
            foreach (var module in query)
            {
                listnotPM.Add(module);
            }
            return listnotPM;
        }
        public bool DeleteSingleModulePermission(ESModulePermission objEmodule)
        {
            _hasanSecurityDataContextObj = new SIPLDBMLDataContext();

            MODULE_PERMISSION module = _hasanSecurityDataContextObj.MODULE_PERMISSIONs.FirstOrDefault(mp => mp.USER_GROUP_ID == objEmodule.UserGroupId && mp.MODULE_NAME == objEmodule.ModuleName);
            if (module != null)
            {
                _hasanSecurityDataContextObj.MODULE_PERMISSIONs.DeleteOnSubmit(module);
                _hasanSecurityDataContextObj.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
