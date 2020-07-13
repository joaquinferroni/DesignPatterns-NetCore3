namespace factory_method
{
    //Creator
    abstract  class PaymentTypeFactory 
    {
        //FactoryMethod
        public abstract IPaymentType GetPaymentType();
    }
}