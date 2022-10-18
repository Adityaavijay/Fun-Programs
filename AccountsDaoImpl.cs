using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Bank_account
{
    class AccountDaoImpl : AccountDao
    {
        //string connectionString = "Data Source=DESKTOP-OMRP96R;Initial Catalog = AccountDetails; Integrated Security = true";
        public void addAnAccount(SavingsAccount account)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Account(AccountNo,AccountBalance,AccountPassword,BankName,MinimumBalance,OverDraftLimit) values(@ano,@abal,@pass,@bank,@bal,null)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ano", account._accNo);
                cmd.Parameters.AddWithValue("@abal", account._accBalance);
                cmd.Parameters.AddWithValue("@pass", account._password);
                cmd.Parameters.AddWithValue("@bank", account._bankName);
                cmd.Parameters.AddWithValue("@bal", account._accBalance);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data Successfully Inserted");
                }
                else
                {
                    Console.WriteLine("Data insertion Failed");
                }
                con.Close();
            }

        }
        public void addAnAccount(CurrentAccount account)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Account(AccountNo,AccountBalance,AccountPassword,BankName,MinimumBalance,OverDraftLimit) values(@ano,@abal,@pass,@bank,null,@bal)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ano", account._accNo);
                cmd.Parameters.AddWithValue("@abal", account._accBalance);
                cmd.Parameters.AddWithValue("@pass", account._password);
                cmd.Parameters.AddWithValue("@bank", account._bankName);
                cmd.Parameters.AddWithValue("@bal", account._overdraftlimit);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data Successfully Inserted");
                }
                else
                {
                    Console.WriteLine("Data insertion Failed");
                }
                con.Close();
            }
        }

        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            string s = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select AccountPassword from Account where AccountNo=@ano", con);
                cmd.Parameters.AddWithValue("@ano", accountNumber);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s = dr[0].ToString();
                }
                con.Close();
                if (s.Equals(oldPassword))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update Account set AccountPassword=@pass where AccountNo=@ano", con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@ano", accountNumber);
                    cmd1.Parameters.AddWithValue("@pass", newPassword);
                    int result = cmd1.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Data Successfully Updated");
                    }
                    else
                    {
                        Console.WriteLine("Data updation Failed");
                    }
                    con.Close();
                }
                else
                {
                    Console.WriteLine("Your password is not matching");
                }

            }
        }

        public void checkBalance()
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Enter the account number");
                int accountNumber = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("select AccountBalance from Account where AccountNo=@ano", con);
                cmd.Parameters.AddWithValue("@ano", accountNumber);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Balance " + dr[0].ToString());
                }
                con.Close();
            }
        }

        public void getAccountDetails(int accountNumber)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Account where AccountNo=@ano", con);
                cmd.Parameters.AddWithValue("@ano", accountNumber);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("AccNo\tAccBalance\tAccPassword\tBank\tMinBalance\tOverDraftLimit");
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);
                }
                con.Close();
            }
        }

        public List<Account> viewAllAccounts()
        {
            throw new NotImplementedException();
        }

     

        public void withdraw(int accountNumber, double amount)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"Appsettings.json", true, true);
            string connectionString = builder.Build().GetConnectionString("DBCon");
            double b = 0;
            string s = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select AccountBalance from Account where AccountNo=@ano", con);
                cmd.Parameters.AddWithValue("@ano", accountNumber);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s = dr[0].ToString();
                }
                b = Double.Parse(s);
                con.Close();
                if (amount < b)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update Account set AccountBalance=AccountBalance-@amt where AccountNo=@ano", con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@ano", accountNumber);
                    cmd1.Parameters.AddWithValue("@amt", amount);
                    int result = cmd1.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Data Successfully Updated");
                    }
                    else
                    {
                        Console.WriteLine("Data updation Failed");
                    }
                    con.Close();
                }
                else
                {
                    Console.WriteLine("Balance is less");
                }

            }
        }

        List<SavingsAccount> AccountDao.viewAllAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
