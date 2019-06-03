using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SalesScreen.CaseInterview.Models;

namespace SalesScreen.CaseInterview.Services
{
    public static class BankService
    {
        private const string BaseUrl = "https://salesscreen-bank-api.azurewebsites.net/api/";

        public static AccountInfo GetAccountInfo(int accountId) {
            var endpoint = $"account/{accountId}";
            var jsonString = GetJson(endpoint);

            return JsonConvert.DeserializeObject<AccountInfo>(jsonString);
        }

        public static List<Transaction> GetTransactions(int accountId) {
            throw new NotImplementedException();
        }

        public static List<Category> GetCategories() {
            throw new NotImplementedException();
        }

        public static List<CategoryMonthlyBudget> GetCategoryMonthlyBudgets(int accountId) {
            throw new NotImplementedException();
        }

        private static string GetJson(string endpoint) {
            using (var client = new HttpClient()) {
                var url = $"{BaseUrl}/{endpoint}";
                var response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}