using CoreLayer.Entities;

namespace EntityLayer.Concrete
{
	public class CustomerAccountProcess:IEntity
    {
        public int Id { get; set; }
        public int ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
