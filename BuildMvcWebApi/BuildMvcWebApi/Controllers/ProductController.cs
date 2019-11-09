using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildMvcWebApi.Dto;
using BuildMvcWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildMvcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("get-all-typeproduct")]
        public List<TypeProduct> GetAllTypeProduct()
        {
            var statusTyeProduct = new int[] { 0 };
            var typeProduct = _context.TypeProducts.Where(c => statusTyeProduct.Contains((int)c.status)).ToList();
            return typeProduct;
        }

        [HttpPost]
        [Route("add-new-type-product")]
        public TypeProduct addNewTypeProduct(TypeProduct model)
        {
            if (model == null)
            {
                return null;
            }
            else
            {
                var typeProduct = new TypeProduct() {
                    Name = model.Name,
                    Description = model.Description,
                    Image = model.Image
                };
                if (typeProduct != null)
                {
                    _context.TypeProducts.Add(typeProduct);
                    _context.SaveChanges();
                }
            }
            return model;
        }

        [HttpPost]
        [Route("update-type-product")]
        public TypeProduct updateTypeProduct(TypeProduct model)
        {
            if (model == null)
            {
                return null;
            }
            else
            {
                var typeProduct = _context.TypeProducts.Where(x => x.Id == model.Id).FirstOrDefault();
                if (typeProduct != null)
                {
                    typeProduct.Description = model.Description;
                    typeProduct.Name = model.Name;
                    typeProduct.Image = model.Image;
                    typeProduct.UpdatedAt = DateTime.Now;
                }
                _context.TypeProducts.Update(typeProduct);
                _context.SaveChanges();
            }
            return model;
        }

        [HttpPost]
        [Route("delete-type-product")]
        public TypeProduct deleteTypeProduct(DeleteByIdDto model)
        {
            if (model.Id != Guid.Empty)
            {
                var typeProduct = _context.TypeProducts.Find(model.Id);
                if (typeProduct != null)
                {
                    _context.TypeProducts.Remove(typeProduct);
                    _context.SaveChanges();
                }
                return typeProduct;
            }
            return null;
        }
    }
}
