﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_2
{
    internal class Contact
    {
        // Khai báo các trường
        private int id;
        private string firstname;
        private string lastname;
        private string address;
        private string phone;
        private string email;

        // Tạo constructor không tham số
        public Contact()
        {
           
        }

        // Tạo constructor với các tham số
        public Contact(int id, string firstname, string lastname, string address, string phone, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        // Tạo thuộc tính cho các trường
        public int Id
        { 
            get {  return id; }
            set { id = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Định nghĩa phương thức display
        public void Display()
        {
            Console.WriteLine("Mã số: " + id);
            Console.WriteLine("Họ và tên: {0} {1}", firstname, lastname);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("Điện thoại: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
