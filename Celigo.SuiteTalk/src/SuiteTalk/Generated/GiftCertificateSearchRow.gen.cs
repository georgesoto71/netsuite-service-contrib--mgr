
// Generator: SearchStubGenerator
// Template: ISearchRow

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class GiftCertificateSearchRow: ISearchRow, ISearchRow<GiftCertificateSearchRowBasic>, ISupportsCustomSearchJoin
    {
        public GiftCertificateSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchRow.GetBasic() => this.basic;

        public GiftCertificateSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new GiftCertificateSearchRowBasic();
            return this.basic;
        }

        ISearchRow<GiftCertificateSearchRowBasic> 
            ISearchRow<GiftCertificateSearchRowBasic>.CreateBasic(Action<GiftCertificateSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public GiftCertificateSearchRow CreateBasic(Action<GiftCertificateSearchRowBasic> initializer)
        {
            var rowBasic = this.CreateBasic();
            initializer(rowBasic);
            return this;
        }

        SearchRowBasic ISearchRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchRow<GiftCertificateSearchRowBasic> 
            ISearchRow<GiftCertificateSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public GiftCertificateSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        // public IEnumerable<SearchRowBasic> GetJoins()
        // {
        //    yield return this.basic;
      //      yield return this.userJoin;
        //}


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(GiftCertificateSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new GiftCertificateSearchRowBasic();
                    break;


                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("GiftCertificateSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}