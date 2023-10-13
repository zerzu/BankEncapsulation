using static System.Formats.Asn1.AsnWriter;
using System;
using System.Security.Principal;

namespace BankEncapsulation
{
    public class Program
    {
        //Create a new public class named BankAccount           DONE!
        //In your BankAccount class, create the following:
        //A private field of type double named **balance** with a value of 0    DONE!!
        //Define a method named Deposit that will accept a double and store that value in the balance field DONE!!
        //Define a method named GetBalance that will return the amount stored in the balance field  DONE!!
        //In the main method of your application, create a new instance of the BankAccount class.   DONE!!
        //Allow the user of the application to Deposit money and retrieve their balance through the console.
        //Once finished save, commit, and push back to Github

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();


            BankAccount.MainMenu(account, true);


        }        
       
            
            
        
    }
}
