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

        public void Delete(Guid? Id)
        {
            User model = db.Users.Find(Id);
            db.Users.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, User model)
        {
            User user = db.Users.Find(Id);

            user.FullName = model.FullName;
            user.Email = model.Email;
            user.Password = model.Password;
            user.Phone = model.Phone;
            user.Address = model.Address;
            

            user.UpdatedAt = DateTime.Now;

            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public User GetUser(Guid? Id)
        {
            User model = db.Users.Find(Id);
            return model;
           
        }
    }
}
