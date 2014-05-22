//-----------------------------------------------------------------------
// <copyright file="IHelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    /// <summary>
    /// The Service Contract.
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Runtime.InteropServices.Guid("23c6e4c4-d8d7-4bef-8d11-420c88bbefc2")]
    internal interface IClubCloudApplicationService
    {
        #region Methods

        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract]
        string HelloWorld(string helloWorld);

        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract]
        string HelloWorldFromDatabase(string helloWorld);

        #endregion
    }
}
