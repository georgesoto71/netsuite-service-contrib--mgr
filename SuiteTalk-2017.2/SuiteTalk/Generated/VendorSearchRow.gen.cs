// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class VendorSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<VendorSearchRowBasic>, SupportsCustomSearchJoin
    {
        public VendorSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public VendorSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new VendorSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<VendorSearchRowBasic> 
            ISearchAdvancedRow<VendorSearchRowBasic>.CreateBasic(Action<VendorSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public VendorSearchRow CreateBasic(Action<VendorSearchRowBasic> initializer)
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

        ISearchAdvancedRow<VendorSearchRowBasic> 
            ISearchAdvancedRow<VendorSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public VendorSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        // public IEnumerable<SearchRowBasic> GetJoins()
        // {
        //    yield return this.basic;
      //      yield return this.accountJoin;
      //      yield return this.campaignResponseJoin;
      //      yield return this.contactJoin;
      //      yield return this.contactPrimaryJoin;
      //      yield return this.expAccountJoin;
      //      yield return this.fileJoin;
      //      yield return this.messagesJoin;
      //      yield return this.messagesFromJoin;
      //      yield return this.messagesToJoin;
      //      yield return this.mseSubsidiaryJoin;
      //      yield return this.timeApproverJoin;
      //      yield return this.transactionJoin;
      //      yield return this.userJoin;
      //      yield return this.userNotesJoin;
        //}


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(VendorSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new VendorSearchRowBasic();
                    break;


                case "accountJoin":
                    result = target.accountJoin;
                    creator = () => target.accountJoin = new AccountSearchRowBasic();
                    break;
        
                case "campaignResponseJoin":
                    result = target.campaignResponseJoin;
                    creator = () => target.campaignResponseJoin = new CampaignSearchRowBasic();
                    break;
        
                case "contactJoin":
                    result = target.contactJoin;
                    creator = () => target.contactJoin = new ContactSearchRowBasic();
                    break;
        
                case "contactPrimaryJoin":
                    result = target.contactPrimaryJoin;
                    creator = () => target.contactPrimaryJoin = new ContactSearchRowBasic();
                    break;
        
                case "expAccountJoin":
                    result = target.expAccountJoin;
                    creator = () => target.expAccountJoin = new AccountSearchRowBasic();
                    break;
        
                case "fileJoin":
                    result = target.fileJoin;
                    creator = () => target.fileJoin = new FileSearchRowBasic();
                    break;
        
                case "messagesJoin":
                    result = target.messagesJoin;
                    creator = () => target.messagesJoin = new MessageSearchRowBasic();
                    break;
        
                case "messagesFromJoin":
                    result = target.messagesFromJoin;
                    creator = () => target.messagesFromJoin = new MessageSearchRowBasic();
                    break;
        
                case "messagesToJoin":
                    result = target.messagesToJoin;
                    creator = () => target.messagesToJoin = new MessageSearchRowBasic();
                    break;
        
                case "mseSubsidiaryJoin":
                    result = target.mseSubsidiaryJoin;
                    creator = () => target.mseSubsidiaryJoin = new MseSubsidiarySearchRowBasic();
                    break;
        
                case "timeApproverJoin":
                    result = target.timeApproverJoin;
                    creator = () => target.timeApproverJoin = new EmployeeSearchRowBasic();
                    break;
        
                case "transactionJoin":
                    result = target.transactionJoin;
                    creator = () => target.transactionJoin = new TransactionSearchRowBasic();
                    break;
        
                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
        
                case "userNotesJoin":
                    result = target.userNotesJoin;
                    creator = () => target.userNotesJoin = new NoteSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("VendorSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}