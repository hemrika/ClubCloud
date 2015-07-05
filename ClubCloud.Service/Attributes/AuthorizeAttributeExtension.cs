﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Attributes
{
    public class AuthorizeAttributeExtension : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new AuthorizeAttribute();
        }

        public override Type BehaviorType
        {
            get { return typeof (AuthorizeAttribute); }
        }
    }
}
