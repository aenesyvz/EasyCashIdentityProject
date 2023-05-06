using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal AccountBalance { get; set; }
        public string BankBranch { get; set; }

        public AppUser AppUser { get; set; }
    }

    public class CustomerAccountProcess
    {
        public int Id { get; set; }
        public int ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ImageUrl { get; set; }

        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
    public class AppRole : IdentityRole<int>
    {

    }
}
