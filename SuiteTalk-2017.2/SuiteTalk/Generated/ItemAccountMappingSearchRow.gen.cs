using System;

namespace SuiteTalk
{
    public partial class ItemAccountMappingSearchRow: IAdvancedSearchRow, IAdvancedSearchRow<ItemAccountMappingSearchRowBasic>, SupportsCustomSearchJoin
    {
        public ItemAccountMappingSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic IAdvancedSearchRow.GetBasic() => this.basic;

        public ItemAccountMappingSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new ItemAccountMappingSearchRowBasic();
            return this.basic;
        }

        public ItemAccountMappingSearchRowBasic CreateBasic(Action<ItemAccountMappingSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return basic;
        }

        SearchRowBasic IAdvancedSearchRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        public J CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return join;
        }


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(ItemAccountMappingSearchRow target, string joinName, bool createIfNull = false)
        {

            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {

                case "classJoin":
                    result = target.classJoin;
                    creator = () => target.classJoin = new ClassificationSearchRowBasic();
                    break;
        
                case "departmentJoin":
                    result = target.departmentJoin;
                    creator = () => target.departmentJoin = new DepartmentSearchRowBasic();
                    break;
        
                case "destinationAccountJoin":
                    result = target.destinationAccountJoin;
                    creator = () => target.destinationAccountJoin = new AccountSearchRowBasic();
                    break;
        
                case "locationJoin":
                    result = target.locationJoin;
                    creator = () => target.locationJoin = new LocationSearchRowBasic();
                    break;
        
                case "sourceAccountJoin":
                    result = target.sourceAccountJoin;
                    creator = () => target.sourceAccountJoin = new AccountSearchRowBasic();
                    break;
        
                case "subsidiaryJoin":
                    result = target.subsidiaryJoin;
                    creator = () => target.subsidiaryJoin = new SubsidiarySearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("ItemAccountMappingSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
                }
    }
}