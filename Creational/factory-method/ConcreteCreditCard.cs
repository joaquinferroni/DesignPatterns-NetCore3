namespace factory_method
{
    //Concrete product 2
    public class ConcreteCreditCard : IPaymentType
    {
        internal ConcreteCreditCard()
        {
            
        }
        public string Charge(decimal amount)
        {
            return $"Result of charge {amount.ToString()} by credit card";
        }
    }
}