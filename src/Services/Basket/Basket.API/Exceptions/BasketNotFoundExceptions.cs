

namespace Basket.API.Exceptions
{
    public class BasketNotFoundExceptions : NotFoundException
    {
        public BasketNotFoundExceptions(string userName) : base("Basket", userName) 
        { 

        }
    }
}
