using Microsoft.EntityFrameworkCore;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Reponsitory
{
    public class UserRepository : IUser
    {
        private SaleOfPastriesDbContext db;

        public UserRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<User> GetUsers => db.Users;

        public void Add(User model)
        {
            db.Users.Add(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, User model)
        {
            User user = db.Users.Find(Id);

            user.Address = model.Address;
            user.UpdatedAt = DateTime.Now;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public User GetUser(Guid? Id)
        {
            User model = db.Users.Find(Id);
            if (model!=null)
            {
                return model;
            }
            throw new Exception("Khong ton tai ban ghi");
           
        }
    }
}
