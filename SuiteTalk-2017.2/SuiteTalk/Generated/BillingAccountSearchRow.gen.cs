// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;

namespace SuiteTalk
{
    public partial class BillingAccountSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<BillingAccountSearchRowBasic>, SupportsCustomSearchJoin
    {
        public BillingAccountSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public BillingAccountSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new BillingAccountSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<BillingAccountSearchRowBasic> 
            ISearchAdvancedRow<BillingAccountSearchRowBasic>.CreateBasic(Action<BillingAccountSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public BillingAccountSearchRow CreateBasic(Action<BillingAccountSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return this;
        }

        SearchRowBasic ISearchAdvancedRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchAdvancedRow<BillingAccountSearchRowBasic> 
            ISearchAdvancedRow<BillingAccountSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public BillingAccountSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(BillingAccountSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new BillingAccountSearchRowBasic();
                    break;

                case "jobJoin":
                    result = target.jobJoin;
                    creator = () => target.jobJoin = new JobSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("BillingAccountSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}