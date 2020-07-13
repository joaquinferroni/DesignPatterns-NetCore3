namespace factory_method
{
    //Concrete product 1
    public class ConcreteDebitCard : IPaymentType
    {
        internal ConcreteDebitCard()
        {
            
        }
        public string Charge(decimal amount)
        {
            return $"Result of charge {amount.ToString()} by debit card";
        }
    }
}