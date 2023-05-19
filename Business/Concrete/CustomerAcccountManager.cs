using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CustomerAcccountManager : ICustomerAccountService
	{
		private readonly ICustomerAccountDal _customerAccountDal;
		public CustomerAcccountManager(ICustomerAccountDal customerAccountDal)
		{
			_customerAccountDal= customerAccountDal;
		}
		public void Add(CustomerAccount customerAccount)
		{
			_customerAccountDal.Add(customerAccount);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<CustomerAccount> GetAll()
		{
			throw new NotImplementedException();
		}

		public CustomerAccount GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(CustomerAccount customerAccount)
		{
			throw new NotImplementedException();
		}
	}
}
