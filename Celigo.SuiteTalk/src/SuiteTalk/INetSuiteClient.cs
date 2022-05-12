using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace SuiteTalk
{
    public partial interface INetSuiteClient : NetSuitePortType, IPreferenceProvider
    {
#pragma warning disable IDE1006 // Naming Styles
        ApplicationInfo applicationInfo { get; set; }
        TokenPassport tokenPassport { get; set; }
        Preferences preferences { get; set; }
        SearchPreferences searchPreferences { get; set; }
        PartnerInfo partnerInfo { get; set; }

        string SuiteTalkVersion { get; }

        ServiceEndpoint Endpoint { get; }

        Task<SearchResult> searchAsync(SearchRecord searchRecord, SearchPreferences searchPref);
#pragma warning restore IDE1006 // Naming Styles

    }

    public partial class NetSuitePortTypeClient : INetSuiteClient
    {
        public ApplicationInfo applicationInfo { get; set; }
        public TokenPassport tokenPassport { get; set; }
        public Preferences preferences { get; set; }
        public SearchPreferences searchPreferences { get; set; }
        public PartnerInfo partnerInfo { get; set; }

        public string SuiteTalkVersion { get { return "2021.2"; } }
        
        public virtual async Task<SearchResult> searchAsync(SearchRecord searchRecord, SearchPreferences searchPref)
        {
            var request = new searchRequest() {
                tokenPassport = tokenPassport,
                applicationInfo = applicationInfo,
                partnerInfo = partnerInfo,
                searchPreferences = searchPref,
                searchRecord = searchRecord,
            };
            var response = await ((NetSuitePortType)this).searchAsync(request);
            return response.searchResult;
        }

        public static System.ServiceModel.EndpointAddress GetDefaultEndpoint()
        {
            return GetDefaultEndpointAddress();
        }

        public virtual async Task<SearchResult> searchAsync(SearchRecord searchRecord)
        {
            return await this.searchAsync(searchRecord, this.searchPreferences);
        }
    }
}