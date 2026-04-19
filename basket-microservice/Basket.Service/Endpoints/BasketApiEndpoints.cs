
using Microsoft.AspNetCore.Mvc;

public static class BasketApiEndpoints
{
   public static void RegisterEndpoints(this IEndpointRouteBuilder routeBuilder)
{
    routeBuilder.MapGet("/{customerId}", (
        [FromServices] IBasketStore basketStore, 
        string customerId)
            => basketStore.GetBasketByCustomerId(customerId));
}
}