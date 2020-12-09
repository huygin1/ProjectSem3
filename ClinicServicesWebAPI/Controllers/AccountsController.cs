using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;
using ClinicServicesWebAPI.DataConnect;

namespace ClinicServicesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccounts iaccounts;
        public AccountsController(IAccounts iaccounts)
        {
            this.iaccounts = iaccounts;
        }
        [HttpGet()]
        public async Task<IEnumerable<Accounts>> GetAccounts()
        {
            return await iaccounts.GetAccounts();
        }
        [HttpGet("{accountID}")]
        public async Task<Accounts> GetAccount(int accountID)
        {
            return await iaccounts.GetAccount(accountID);
        }
        [HttpPost()]
        public async Task<Accounts> PostAccounts(Accounts accounts)
        {
            return await iaccounts.PostAccounts(accounts);
        }
        [HttpPut()]
        public async Task<Accounts> PutAccounts(Accounts accounts)
        {
            return await iaccounts.PutAccounts(accounts);
        }
        [HttpDelete("{accountID}")]
        public async Task<Accounts> DeleteAccount(int accountID)
        {
            return await iaccounts.DeleteAccount(accountID);
        }
    }
}
