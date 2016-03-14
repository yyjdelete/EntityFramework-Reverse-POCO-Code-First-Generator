using EntityFramework_Reverse_POCO_Generator;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tester.BusinessLogic
{
    public interface ICustomersRepository
    {
        IQueryable<Customer> GetTop10();

        Task<List<Customer>> GetTop10Async();

        int Count();

        Customer FindById(string id);

#if false
        Customer Find(string id);
#endif

        void AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
    }
}
