using ClubCloud.Social.Google.Analytics.Objects;

namespace ClubCloud.Social.Google.Analytics.Interfaces {
    
    public interface IAnalyticsSortField {

        AnalyticsSortOrder Order { get; }

        IAnalyticsField Field { get; }

    }

}