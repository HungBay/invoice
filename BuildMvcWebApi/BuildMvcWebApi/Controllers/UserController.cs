using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildMvcWebApi.Dto;
using BuildMvcWebApi.Models;
using BuildMvcWebApi.Respon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildMvcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public UserController(EcommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("get-all-user")]
        public List<UserRespon> getAllUser()
        {
            var users = _context.Users.Select(x => new UserRespon() {
                Name = x.FullName,
                Address = x.Address,
                Email = x.Email,
                Phone = x.Phone,
                Password = x.Password
            }).ToList();
            return users;
        }

        [HttpPost]
        [Route("add-new-user")]
        public User addNewUser(User model)
        {
            if (model != null)
            {
                var user = new User() { FullName = model.FullName, Email = model.Email, Password = model.Password, Phone = model.Phone, Image = model.Image, Address = model.Address};
                _context.Users.Add(user);
                _context.SaveChanges();
                return model;
            }
            return null;
        }

        [HttpPost]
        [Route("update-user")]
        public User updateUser(UserDto model)
        {
            if (model != null)
            {
                var user = _context.Users.Where(x => x.Id == model.Id).FirstOrDefault();
                user.Address = model.Address;
                _context.Users.Update(user);
                _context.SaveChanges();
                return user;
            }
            return null;
        }

        [HttpPost]
        [Route("delete-type-product")]
        public TypeProduct deleteTypeProduct(DeleteByIdDto model)
        {
            if (model.Id != Guid.Empty)
            {
                var typeProduct = _context.TypeProducts.Where(x => x.Id == model.Id).FirstOrDefault();
                if (typeProduct != null)
                {
                    _context.TypeProducts.Remove(typeProduct);
                    _context.SaveChanges();
                }
                return typeProduct;
            }
            return null;
        }


        [HttpPost]
        [Route("delete-users")]
        public List<User> deleteUser(List<DeleteByIdDto> model)
        {
            var user = new List<User>();
            foreach (var item in model)
            {
                if (item.Id != Guid.Empty)
                {
                    var users = _context.Users.Where(x => x.Id == item.Id).FirstOrDefault();
                    user.Add(users);
                }
            }
            if (user != null)
            {
                _context.Users.RemoveRange(user);
                _context.SaveChanges();
                return user;
            }
            return null;
        }
    }
}