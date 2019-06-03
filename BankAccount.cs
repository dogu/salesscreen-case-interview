using System;
using SalesScreen.CaseInterview.Models;
using SalesScreen.CaseInterview.Services;

namespace SalesScreen.CaseInterview
{
    public class BankAccount {
        private readonly int AccountId;
        private AccountInfo _accountInfo;

        public BankAccount(int accountId) {
            AccountId = accountId;
        }

        public double GetAvailableFunds() {
            return _accountInfo.Balance + _accountInfo.Balance;
        }

        #region API

        public void FetchAccountInfo() {
            _accountInfo = BankService.GetAccountInfo(AccountId);
        }

        #endregion
    }
}