using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentTypeFactory pf = null;
            while (true)
            {

                Console.WriteLine("Select payment method: \n1_ credit \n2_ debit \nother_ exit");
                string pmethod = Console.ReadLine();

                switch (pmethod)
                {
                    case "1":
                        pf = new CreditCardCreator();
                        break;
                    case "2":
                        pf = new DebitCardCreator();
                        break;
                    default:
                        Console.WriteLine("No payment selected.");
                        return;
                }

                IPaymentType pt = pf.GetPaymentType();

                Console.WriteLine(pt.Charge(1000));
            }

        }
    }
}
