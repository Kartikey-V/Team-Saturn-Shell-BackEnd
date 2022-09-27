using ContosFS.Data.GraphQL.Type;
using ContosFS.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosFS.Data.GraphQL
{
    public class UserQuery: ObjectGraphType
    {
        public UserQuery (UserRepository repository)
        {
            Field<ListGraphType<UserType>>("users",
                resolve: context => repository.GetUser());
        }
    }
}
