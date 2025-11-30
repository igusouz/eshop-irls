namespace Basket.API.Exceptions
{
    public class BasketNotFoundExecption : NotFoundException
    {
        public BasketNotFoundExecption(string userName) : base("Basket", userName)
        {
            
        }
    }
}
