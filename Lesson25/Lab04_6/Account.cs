using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_6
{ 
    public class Account
    {
        public decimal Balance;
        // Constructor với tham số đầu vào
        public Account(decimal initialize)
        {
            if (initialize < 0)
            {
                throw new ArgumentException("Số tiền đầu vào không hợp lệ");
            }
            Balance = initialize;
        }
        // tạo phương thức cho lớp Account

        // Phương thức trả về số tiền trong tài khoản

        // Phương thức gửi tiền cho ghi đè
        public virtual void Deposit(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
            }
            else
            {
                throw new ArgumentException(" Số tiền nạp vào không hợp lệ");
            }
        }
        // Phương thức rút tiền từ tài khoản
        public virtual void WithDraw(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("Số tiền rút không hợp lệ");
            }
            if (money > Balance)
            {
                throw new ArgumentException("Không đủ số dư để rút tiền");
            }
            else
            {
                Balance -= money;
            }
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }

    public class SavingAccount : Account
    {
        private decimal rate;// tỉ lệ lãi suất
        // Constructor với 3 tham số đầu vào để khoeir tạo giá trị ban đầu
        public SavingAccount(decimal initialize, decimal rate) : base(initialize)
        {
            // Kiểm tra nếu tỷ lệ lãi suất là số âm thì không  cho phép và hiển thị thôn báo\
            if (rate < 0)
            {
                throw new ArgumentException("tỉ lệ lãi suất không hợp lệ");
            }
            this.rate = rate;

        }
        // Phương thức để lấy tiền lãi
        public decimal GetInterest()
        {
            return rate * rate;
        }
    }
    public class CheckAccount : Account
    {
        private decimal Fee;
        // tạo phương thức constructor với 2tham số đầu vào
        public CheckAccount(decimal initialize, decimal rate) : base(initialize)
        {
            if (Fee < 0)
            {
                throw new ArgumentException("Phí giao dịch không hợp lệ");
            }
            this.Fee = Fee;
        }
        public override void Deposit(decimal money)
        {
            base.Deposit(money);

        }
        public override void WithDraw(decimal money)
        {
            base.WithDraw(money);
        }
    }
}