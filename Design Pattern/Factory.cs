using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_DesignPattern
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;

            if(cardType == "MoneyBack")
            {
                cardDetails = new MoneyBank();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }
}
