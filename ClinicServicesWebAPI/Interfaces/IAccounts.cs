using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface IAccounts
    {
        Task<IEnumerable<Accounts>> GetAccounts();
        Task<Accounts> GetAccount(int accountID);
        Task<Accounts> PostAccounts(Accounts accounts);
        Task<Accounts> PutAccounts(Accounts accounts);
        Task<Accounts> DeleteAccount(int accountID);
    }
}
