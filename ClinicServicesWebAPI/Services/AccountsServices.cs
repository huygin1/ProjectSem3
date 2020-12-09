using ClinicServicesWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;

namespace ClinicServicesWebAPI.Services
{
    public class AccountsServices : IAccounts
    {
        private ClinicContext context;
        public AccountsServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Accounts>> GetAccounts()
        {
            return context.Accounts.ToList();
        }
      
        public async Task<Accounts> GetAccount(int accountID)
        {
            Accounts account = context.Accounts.SingleOrDefault(e => e.AccountID.Equals(accountID));
            if (account != null)
            {
                return account;
            }
            else
            { return null; }
        }

        public async Task<Accounts> PostAccounts(Accounts accounts)
        {
            Accounts acc = context.Accounts.SingleOrDefault(a => a.AccountID.Equals(accounts.AccountID));
            if (acc != null)
            {
                //var key = "b14ca5898a4e4133bbce2ea2315a1916";
                //accounts.Password = AesEncDesc.EncryptString(key, accounts.Password);
                context.Accounts.Add(accounts);
                context.SaveChanges();
                return accounts;
            }
            else
            {
                return null;
            }
        }

        public async Task<Accounts> PutAccounts(Accounts accounts)
        {
            Accounts acc = context.Accounts.SingleOrDefault(a => a.AccountID.Equals(accounts.AccountID));
            if (acc != null)
            {
                acc.AccountName = accounts.AccountName;
                acc.Password = accounts.Password;
                acc.FirstName = accounts.FirstName;
                acc.LastName = accounts.LastName;             
                acc.Email = accounts.Email;
                acc.Role = accounts.Role;
                acc.Phone = accounts.Phone;
                acc.DoB = accounts.DoB;
                acc.AccountHistory = accounts.AccountHistory;
                acc.AccountLock = accounts.AccountLock;            
                acc.Country = accounts.Country;
                acc.City = accounts.City;
                acc.State = accounts.State;
                acc.District = accounts.District;
                acc.Street = accounts.Street;
                acc.Zipcode = accounts.Zipcode;
                acc.Image = accounts.Image;
                context.SaveChanges();
                return accounts;
            }
            else
            {
                return null;
            }
        }
        public async Task<Accounts> DeleteAccount(int accountID)
        {
            Accounts account = context.Accounts.Where(a => a.AccountID.Equals(accountID)).FirstOrDefault();
            if (account != null)
            {
                context.Accounts.Remove(account);
                context.SaveChanges();
            }
            else
            {
                //no thing 
            }
            return null;
        }

    }
}
