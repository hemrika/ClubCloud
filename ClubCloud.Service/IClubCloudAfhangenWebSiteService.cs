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
    [ServiceContract(Namespace = "http://nl.clubcloud/", Name = "Afhangen")]
    public interface IClubCloudAfhangenWebSiteService
    {
        [OperationContract]
        LoginResult Login(string username, string password);

        [OperationContract]
        void Logout();

        [OperationContract]
        LoginResult IsAuthorized();

    }
}
