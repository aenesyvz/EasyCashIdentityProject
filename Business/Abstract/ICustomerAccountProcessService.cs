using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICustomerAccountProcessService
	{
		void Add(CustomerAccountProcess customerAccountProcess);
		void Update(CustomerAccountProcess customerAccountProcess);
		void Delete(int id);
		List<CustomerAccountProcess> GetAll();
		CustomerAccountProcess GetById(int id);
	}
}
