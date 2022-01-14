using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Atm {

//     class Person{
//         string name;
//         int accNumber;
//         int totalBalance;
//         int pinCode;
//         
//         public void PutData(string name, int accNumber, int totalBalance, int pinCode){
//             this.name = name;
//             this.accNumber = accNumber;
//             this.totalBalance = totalBalance;
//             this.pinCode = pinCode;
//         }
// 
//         public void Getdata(){
// 
//         }
// 
//     }
    class Bank {

        string name;
        int accnumber;
        int pinCode;
        int totalBalance=0;
        private List<Dictionary<int,int>> ll = new List<Dictionary<int,int>>();

        int i = 3;
        bool f = true;

        public bool ValidateCustomerDetails() {
            while(true){
                Console.WriteLine("hlkjkl");
            }
            
            int accountNumber = -1;
            int pinNumber = -1;
            bool isAccountInvalid = true;

            while(isAccountInvalid) {
                Console.WriteLine("Please enter your Bank account Number: ");
                accountNumber = Convert.ToInt32(Console.ReadLine());

                if(accountNumber == ll.) {
                    isAccountInvalid = false;
                    ll.Add(person);
                } else {
                    Console.WriteLine("Invalid Account Number! Try again.");
                }
            }

            Console.WriteLine("Enter your Customer PIN: ");
            pinNumber = Convert.ToInt32(Console.ReadLine());

            if(pinNumber == pinCode){
                return true;
            } else {
                Console.WriteLine("Invalid PinCode");
                return false;
            }
        }
        public void SetValue(){
            int[] arrayData = new int[3]; 
            Dictionary<string, int[]> dictData = new Dictionary<string, int[]>();

            Console.WriteLine("Enter name\n");
            name = Console.ReadLine();

            Console.WriteLine("Enter Account number");
            accnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Balance");
            totalBalance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter PinCode");
            pinCode = Convert.ToInt32(Console.ReadLine());

            arrayData[0] = accnumber;
            arrayData[1] = totalBalance;
            arrayData[2] = pinCode;
            dictData.Add(name,arrayData);

            ll.Add(dictData);
        }

        public void ShowData(){
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Account No: {0}",accnumber);
            Console.WriteLine("Account type: {0}",type);
            Console.WriteLine("Balance: {0}",tot);
        }

        public void Deposit(){
            Console.WriteLine("Enter amount to be Deposited");
            amount = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowBalance(){
            tot = tot + amount;
            Console.WriteLine("Total balance is: {0}",tot);
        }

        public void Withdrawl(){
            int a, availableBalance;
            Console.WriteLine("Enter amount to withdraw");
            a = Convert.ToInt32(Console.ReadLine());
            availableBalance = tot - a;
            Console.WriteLine("Available Balance is {0}",availableBalance);
        }
    }
}