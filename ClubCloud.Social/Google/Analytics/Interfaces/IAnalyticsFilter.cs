using ClubCloud.Social.Google.Analytics.Objects;

namespace ClubCloud.Social.Google.Analytics.Interfaces {

    public interface IAnalyticsFilter : IAnalyticsFilterBlock {

        string Name { get; }
        string OperatorValue { get; }
        object Value { get; }
        
    }

}
