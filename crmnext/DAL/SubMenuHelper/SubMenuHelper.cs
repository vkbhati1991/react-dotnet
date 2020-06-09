using IDAL.ISubMenu;
using MODEL.SubMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubMenuHelper
{
    public class SubMenuHelper : ISubMenu
    {
        string connectionstring = ConnectionString.CName;

        public string CreateSubMenu(SubMenu subMenu)
        {
            throw new NotImplementedException();
        }

        public List<SubMenu> GetAllSubMenu()
        {
            List<SubMenu> subMenus = DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetSubMenu", r => r.TranslateAsSubMenuList());
            return subMenus;
        }
    }
}
