using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.DTOS
{
    public enum MessageType
    {
        Success = 0,
        Warning = 2,
        Delete = 3,
        Fail = 4
    }

    public enum CaptionPosition
    { 
        Left = 0,
        Top = 1
    }

    public enum PageType
    { 
        NewEdit = 0,
        Detail = 1,
        Detail360 = 2,
        Home = 4
    }

    public enum ColumnFormater
    { 
        Progress = 1,
        Image = 2,
        Link = 3
    }
}
