using System;

namespace SuiteTalk
{
    public partial class VendorCategorySearchRow: SearchRow<VendorCategorySearchRowBasic>
    {
        public VendorCategorySearchRowBasic GetBasic() => this.basic;

        public VendorCategorySearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new VendorCategorySearchRowBasic();
            return this.basic;
        }

        public VendorCategorySearchRowBasic CreateBasic(Action<VendorCategorySearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return basic;
        }

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

        private static SearchRowBasic GetOrCreateJoin(VendorCategorySearchRow target, string joinName, bool createIfNull = false)
        {

            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {

                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("VendorCategorySearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
                }
    }
}