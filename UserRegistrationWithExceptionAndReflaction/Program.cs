﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithExceptionAndReflaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation(); // Creating a object of Validation class
            Console.WriteLine("MSTesting");
            Console.WriteLine("\nWelcome to C# User's Information validation using Regular Expression");
        //User First name validation            
        Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your first name : ");
            string fName = Console.ReadLine(); //storing first name entered by user in variable
            string checkFirstName = validation.FirstNameValidation(fName); //Calling method to check first name is valid or not with argument
            if(checkFirstName != "Input is valid")//If not valid then ask user to enter first name again
                goto Firstname;

           // User Last name validation
            Lastname:
            Console.WriteLine("\nNote : Your Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your last name : ");
            string lName = Console.ReadLine(); //storing last name entered by user in variable
            string checkLastName = validation.LastNameValidation(lName); //Calling method to check last name is valid or not with argument
            if (checkLastName == "Input is valid")//If not valid then ask user to enter last name again
                goto Lastname;

           // User Email Validation
           Email:
            Console.WriteLine("\n\nEnter your email name : ");
            string email = Console.ReadLine(); //storing email address entered by user in variable
            string checkEmail = validation.EmailValidation(email); //Calling method to check email is valid or not with argument
            if (checkEmail != "Input is valid")//If not valid then ask user to enter email again
                goto Email;

            //user Mobile Number validation
            MobileNumber:
            Console.WriteLine("\n\nEnter your Mobile Number : ");
            string mNo = Console.ReadLine(); //storing mobile number entered by user in variable
            string checkMobileNo = validation.MobileNumberValidation(mNo); //Calling method to check mobile number is valid or not with argument
            if (checkMobileNo != "Input is valid")//If not valid then ask user to enter mobile number again
                goto MobileNumber;

            //user Password validation
            Password:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password = Console.ReadLine(); //storing password entered by user in variable
            string checkPassword = validation.PasswordRule1Validation(password); //Calling method to check password follows all the rules or not with argument
            if (checkPassword != "Input is valid")//If not follow then ask user to enter password again
                goto Password;

            //user Password validation
            Password2:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password2 = Console.ReadLine(); //storing password entered by user in variable
            string checkPassword2 = validation.PasswordRule2Validation(password2); //Calling method to check password follows all the rules or not with argument
            if (checkPassword2 != "Input is valid")//If not follow then ask user to enter password again
                goto Password2;

            //user Password validation
            Password3:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password3 = Console.ReadLine(); //storing password entered by user in variable
            string checkPassword3 = validation.PasswordRule3Validation(password3); //Calling method to check password follows all the rules or not with argument
            if (checkPassword3 != "Input is valid")//If not follow then ask user to enter password again
                goto Password3;

            //user Password validation
            Password4:
            Console.WriteLine("\nPassword Rules");
            Console.WriteLine("Rule 1 : Minimum 8 Character");
            Console.WriteLine("Rule 2 : Atleast one Uppercase letter");
            Console.WriteLine("\n\nEnter your Password : ");
            string password4 = Console.ReadLine(); //storing password entered by user in variable
            string checkPassword4 = validation.PasswordRule4Validation(password4); //Calling method to check password follows all the rules or not with argument
            if (checkPassword4 != "Input is valid")//If not follow then ask user to enter password again
                goto Password4;
        }
    }
}
