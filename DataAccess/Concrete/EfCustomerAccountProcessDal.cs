using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
	public class EfCustomerAccountProcessDal : EfEntityRepositoryBase<CustomerAccountProcess, Context>, ICustomerAccountProcessDal
	{

	}
}
