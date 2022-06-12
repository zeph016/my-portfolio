using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_portfolio.domain.clsEnums
{
    public class Enums
    {
        public enum LinkType : byte
        {
            [Description("Github")]
            GitHub = 0,
            [Description("Facebook")]
            Facebook = 1,
            [Description("Instagram")]
            Instagram = 2,
            [Description("Twitter")]
            Twitter = 3
        }
    }
}