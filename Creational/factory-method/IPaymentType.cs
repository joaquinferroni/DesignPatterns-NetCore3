namespace factory_method
{
    //Interface that define the method to be implemented in every concrete product
    public interface IPaymentType
    {
        string Charge(decimal amount);
    }
}