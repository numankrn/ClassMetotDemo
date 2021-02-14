using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 15264874;
            customer1.Name = "Zülfü";
            customer1.Surname = "Aydal";
            customer1.IdentityNumber = 16264859487;

            Customer customer2 = new Customer();
            customer2.Id = 16248582;
            customer2.Name = "Efe";
            customer2.Surname = "Taşkın";
            customer2.IdentityNumber = 16259487231;

            Customer customer3 = new Customer();
            customer3.Id = 19324856;
            customer3.Name = "Numan";
            customer3.Surname = "Kıran";
            customer3.IdentityNumber = 68542931871;

            Customer customer4 = new Customer();
            customer4.Id = 5482168;
            customer4.Name = "Elvis";
            customer4.Surname = "Kor";
            customer4.IdentityNumber = 65421937841;

            Customer[] customers = new Customer[] {customer1, customer2, customer3, customer4 };
            
            
            
            foreach (Customer customerf in customers)
            {
                
                Console.WriteLine("Müşteri Adı-Soyadı :" + "\t" + customerf.Name + " " + customerf.Surname);
                
            }


            CustomerManager.CustomerAdd(customer1);
            CustomerManager.CustomerAdd(customer2);
            CustomerManager.CustomerAdd(customer3);
            CustomerManager.CustomerAdd(customer4);
            CustomerManager.CustomerRemove(customer1);
            CustomerManager.CustomerRemove(customer2);
            CustomerManager.CustomerRemove(customer3);
            CustomerManager.CustomerRemove(customer4);
            CustomerManager.CustomerList(customer1);
            CustomerManager.CustomerList(customer2);
            CustomerManager.CustomerList(customer3);
            CustomerManager.CustomerList(customer4);






        }
    }
}
