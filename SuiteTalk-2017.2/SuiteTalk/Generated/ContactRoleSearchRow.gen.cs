using System;

namespace SuiteTalk
{
    public partial class ContactRoleSearchRow: SearchRow<ContactRoleSearchRowBasic>
    {
        public ContactRoleSearchRowBasic GetBasic() => this.basic;

        public ContactRoleSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new ContactRoleSearchRowBasic();
            return this.basic;
        }

        public ContactRoleSearchRowBasic CreateBasic(Action<ContactRoleSearchRowBasic> initializer)
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

        private static SearchRowBasic GetOrCreateJoin(ContactRoleSearchRow target, string joinName, bool createIfNull = false)
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
                    throw new ArgumentException("ContactRoleSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
                }
    }
}