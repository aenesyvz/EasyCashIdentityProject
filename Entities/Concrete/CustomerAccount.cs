using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class CustomerAccount:IEntity
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal AccountBalance { get; set; }
        public string BankBranch { get; set; }

        public AppUser AppUser { get; set; }
    }
}
