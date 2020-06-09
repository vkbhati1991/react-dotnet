using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.SubMenu
{
    public class SubMenu
    {
        public int SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
    }
}
