namespace factory_method
{
    //Concrete creator 2
    class CreditCardCreator : PaymentTypeFactory
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IPaymentType GetPaymentType()
        {
            return new ConcreteCreditCard();
        }
    }
}