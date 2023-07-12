using System;

namespace Factory_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the type of card :");
            CreditCard cardDetails = CreditCardFactory.GetCreditCard(Console.ReadLine());

            if(cardDetails != null)
            {
                Console.WriteLine("CardType :" +" "+ cardDetails.GetCardType());
                Console.WriteLine("CreditLimit :" +" "+ cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" +" "+cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}
