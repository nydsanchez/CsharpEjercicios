﻿string [] fraundalentOrdersId = ["B123", "C234", "A345", "C15","B177","G3003","C235","B179"];

foreach (string orders in fraundalentOrdersId)
{
    if (orders.StartsWith("B"))
    {
        Console.WriteLine(orders);
    }
}
