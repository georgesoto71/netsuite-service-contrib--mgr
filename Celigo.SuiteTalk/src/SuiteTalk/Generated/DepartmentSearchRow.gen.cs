
// Generator: SearchStubGenerator
// Template: ISearchRow

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class DepartmentSearchRow: ISearchRow, ISearchRow<DepartmentSearchRowBasic>, ISupportsCustomSearchJoin
    {
        public DepartmentSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchRow.GetBasic() => this.basic;

        public DepartmentSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new DepartmentSearchRowBasic();
            return this.basic;
        }

        ISearchRow<DepartmentSearchRowBasic> 
            ISearchRow<DepartmentSearchRowBasic>.CreateBasic(Action<DepartmentSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public DepartmentSearchRow CreateBasic(Action<DepartmentSearchRowBasic> initializer)
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

        ISearchRow<DepartmentSearchRowBasic> 
            ISearchRow<DepartmentSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public DepartmentSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
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
        private static SearchRowBasic GetOrCreateJoin(DepartmentSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new DepartmentSearchRowBasic();
                    break;


                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("DepartmentSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}