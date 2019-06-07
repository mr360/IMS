using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Manager;
using IMS.User;
using IMS.Tools;

namespace IMS.Instance
{
    public class UserInstance : Instance
    {
        public UserInstance(UserManager um) : base(um)
        {

        }

        public User.User LocateUser(Type userType, string userId)
        {
            User.User _user = _manager["User"].Retrieve(userId) as User.User;

            switch (userType.Name)
            {
                case nameof(Staff):
                    _user = _user as Staff;
                    return _user;
                case nameof(Customer):
                    _user = _user as Customer;
                    return _user;
                default:
                    return null;
            }
        }

        public string CreateUser(User.User user)
        {
            if (!ValidateIMS.IsValid(user))
            {
                return "Fail. Not right format";
            }

            return _manager["User"].Add(user);
        }

    }
}
