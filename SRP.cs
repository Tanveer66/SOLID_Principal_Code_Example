namespace SRP
{
    //The below code voilate SRP
    class Customer
    {
        string name;
        int age;

        //properties 
        public string Name { set { this.name = value; } get { return this.name; } }
        //properties
        public int Age { set { this.age = value; } get { return this.age; } }

        public bool SaveCustomer(Customer obj)
        {
            Console.WriteLine("Customer Data Save Succefull");

            return true;
        }

        public bool SendEmail()
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