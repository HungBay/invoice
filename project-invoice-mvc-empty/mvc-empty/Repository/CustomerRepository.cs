using mvc_empty.Models;
using mvc_empty.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Repository
{
    public class CustomerRepository : ICustomer
    {
        private List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>
            {
                new Customer () { ID_KHACHHANG=1, TEN_KHACH_HANG="Nguyễn Văn Hùng", DIA_CHI_KHACH_HANG="Liên Hà - Đan Phượng - Hà Nội"},
                new Customer () { ID_KHACHHANG=2, TEN_KHACH_HANG="Nguyễn Văn Hưng", DIA_CHI_KHACH_HANG="Liên Hà - Đan Phượng - Hà Nội"},
                new Customer () { ID_KHACHHANG=3, TEN_KHACH_HANG="Nguyễn Thị Phương Uyên", DIA_CHI_KHACH_HANG="Liên Hà - Đan Phượng - Hà Nội"},
            };
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int? Id)
        {
            return _customerList.FirstOrDefault(x => x.ID_KHACHHANG == Id);
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
