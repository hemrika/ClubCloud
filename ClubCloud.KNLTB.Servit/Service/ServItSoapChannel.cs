﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace ClubCloud.KNLTB.Servit
{
    internal interface ServItSoapChannel : SoapHttpClientProtocol, ServItSoap, System.ServiceModel.IClientChannel
    {
    }
}
