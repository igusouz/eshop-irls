namespace Basket.API.Basket.StoreBasket
{
    public record StoreBasketCommand(ShoppingCart Cart) : ICommand<StoreBasketResult>;

    public record StoreBasketResult(string UserName);

    public class StoreBasketCommandValidator : AbstractValidator< StoreBasketCommand>
    {
        public StoreBasketCommandValidator()
        {
            RuleFor(x => x.Cart).NotNull().WithMessage("Shopping cart must be provided.");
            RuleFor(x => x.Cart.UserName).NotEmpty().WithMessage("User name must be provided.");
        }
    }

    public class StoreBasketCommmandHandler : ICommandHandler<StoreBasketCommand, StoreBasketResult>
    {
        public async Task<StoreBasketResult> Handle(StoreBasketCommand commmand, CancellationToken cancellationToken)
        {
            ShoppingCart cart = commmand.Cart;

            // TODO: Implement the logic to store the shopping cart
            // TODO: Update cache
            
            return new StoreBasketResult("swn");
        }
    }
}
