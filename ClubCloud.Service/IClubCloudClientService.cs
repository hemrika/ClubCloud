//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{

    using ClubCloud.Model;
    using Microsoft.SharePoint;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceKnownType("GetKnownTypes", typeof(BeheerContainer_KnownTypes))]
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    public interface IClubCloudClientService
    {
        #region WebSite

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string[] GetGebruikers(string prefixText, int count, string contextKey);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string[] GetVerenigingen(string prefixText, int count, string contextKey);

        #endregion

        #region Store

        #endregion
    }
}
