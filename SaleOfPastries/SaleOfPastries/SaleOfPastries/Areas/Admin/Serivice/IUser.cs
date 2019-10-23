using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface IUser
    {
        IEnumerable<User> GetUsers { get; }
        User GetUser(Guid? Id);
        void Add(User model);
        void Edit(Guid? Id, User model);
        void Delete(Guid? Id);
    }
}
