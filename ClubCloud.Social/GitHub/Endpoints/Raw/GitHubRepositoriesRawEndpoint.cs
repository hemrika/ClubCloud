using System;
using ClubCloud.Social.GitHub.OAuth;

namespace ClubCloud.Social.GitHub.Endpoints.Raw {
    
    public class GitHubRepositoriesRawEndpoint {

        #region Properties

        public GitHubOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal GitHubRepositoriesRawEndpoint(GitHubOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        public string GetContents(string owner, string repository, string path) {
            return SocialUtils.DoHttpGetRequestAndGetBodyAsString(
                Client.GenerateAbsoluteUrl(String.Format("/repos/{0}/{1}/contents/{2}", owner, repository, path))
            );
        }

        public string GetRespositories(string username) {
            return SocialUtils.DoHttpGetRequestAndGetBodyAsString(
                Client.GenerateAbsoluteUrl("/" + (username == null ? "user" : "users/" + username) + "/repos")
            );
        }

        #endregion

    }

}
