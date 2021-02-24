using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public static void CustomerAdd(Customer customers)
        {

            Console.WriteLine("----------Müşteri Eklendi!----------");
            Console.WriteLine("Müşteri Numarası :" + "\t\t" + customers.Id);
            Console.WriteLine("Müşteri Adı-Soyadı :" + "\t\t" + customers.Name + " " + customers.Surname);
            Console.WriteLine("Müşteri TC Kimlik Numarası :" + "\t" + customers.IdentityNumber + "\n");
            

        }


        public static void CustomerRemove(Customer customers)
        {
            Console.WriteLine("----------Müşteri Silindi!----------");
            Console.WriteLine("Müşteri Numarası :" + "\t\t" + customers.Id);
            Console.WriteLine("Müşteri Adı-Soyadı :" + "\t\t" + customers.Name + " " + customers.Surname);
            Console.WriteLine("Müşteri TC Kimlik Numarası :" + "\t" + customers.IdentityNumber + "\n");
            

        }

        public static void CustomerList(Customer customers)
        {
            Console.WriteLine("----------Müşteri Listelendi!----------");
            Console.WriteLine("Müşteri Numarası :" + "\t\t" + customers.Id);
            Console.WriteLine("Müşteri Adı-Soyadı :" + "\t\t" + customers.Name + " " + customers.Surname);
            Console.WriteLine("Müşteri TC Kimlik Numarası :" + "\t" + customers.IdentityNumber + "\n");
            
        }




    }
}
