namespace SRP
{
    //The below code voilate SRP
   public  class Customer
    {
        string? name;
        int age;

        public static bool SaveCustomer(Customer obj)
        {
            Console.WriteLine("Customer Data Save Succefull");

            return true;
        }

        public static bool SendEmail()
        {
            Console.WriteLine("Sending Mail....");
            return true;
        }

    }

    /*the above code violate the single responsibilty principal
      The Customer class have more then one responsibilties 
      the customer class savCustomer data AND Send Email. 

    */
    //The below Code have avoid the voilation and Acheive SRP 
    public class Customer_
    {
        public void SaveCustomer()
        {
            Console.WriteLine("Savinf customer Data");
        }

        /*here we can add more responsibiltes Like DeleteCustomer() , UpdateCustomer()
        the class should change for one resone which Customer 
        */
    }
    public class Customer_Email
    {
        public void Send_Email()
        {
            Console.WriteLine("Sending Mail....");
        }

        //here we can add more responsiblites related to Customer Email , Like -recive main
    }
}
/*
The Customer class is now responsible solely for storing customer information. 
It has no knowledge of email sending logic.

· The EmailService class is introduced to handle email-related responsibilities. 
It encapsulates the logic for sending email notifications.

This refactoring adheres to the Single Responsibility Principle. 
The Customer class has one reason to change (customer information-related changes), 
and the EmailService class has one reason to change (email-related changes). 
This separation makes the code more maintainable, easier to understand, 
and allows each class to evolve independently as per their specific responsibilities.
*/