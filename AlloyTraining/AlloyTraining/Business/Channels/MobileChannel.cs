﻿using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AlloyTraining.Business.Channels
{
    public class MobileChannel : DisplayChannel
    {
        public override string ChannelName
        {
            get
            {
                return "Mobile";
            }
        }

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }

        public override string DisplayName
        {
            get
            {
                return "Mobile";
            }
        }

        public override string ResolutionId
        {
            get
            {
                return typeof(MobileResolution).FullName;
            }
        }
    }
}
