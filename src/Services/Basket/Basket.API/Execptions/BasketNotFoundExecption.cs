namespace Basket.API.Execptions
{
    public class BasketNotFoundExecption : NotFoundException
    {
        public BasketNotFoundExecption(string userName) : base("Basket", userName)
        {
            
        }
    }
}
