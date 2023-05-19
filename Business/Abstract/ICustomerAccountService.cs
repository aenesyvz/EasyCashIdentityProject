using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICustomerAccountService
	{
		void Add(CustomerAccount customerAccount);
		void Update(CustomerAccount customerAccount);
		void Delete(int id);

		List<CustomerAccount> GetAll();
		CustomerAccount GetById(int id);
	}
}
