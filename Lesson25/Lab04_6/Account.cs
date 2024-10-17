using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_6
{
    internal class Account
    {
        protected double balance;

        // Constructor mặc định với giá trị khởi tạo của số dư
        public Account(double initialBalance) 
        {
            balance = initialBalance;        
        }

        // Phương thức gửi tiền
        public void Deposit(double money)
        {
            if (money > 0)
            {
                balance += money;
                Console.WriteLine("Deposit successful. New balance: {0}", balance);
            }
            else
            {
                Console.WriteLine("Amount to deposit must be greater tham zoro.");
            }
        }

        // Phương thức rút tiền
        public void Withdraw(double money)
        {
            if (money > 0 && balance >=money)
            {
                balance -= money;
                Console.WriteLine("Withdraw successful. New balance: {0}", balance, money);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdraw amount.");
            }
        }

        // Phương thức lấy số dư hiện tại
        public double GetBalance() 
        { 
            return balance; 
        }

    }
}
