using System;
class HerbalProduct : Product
{
    public string HerbsUsed { get; set; }
    public DateTime MfDate { get; set; }
    public DateTime ExpDate { get; set; }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Herbs Used: {HerbsUsed}");
        Console.WriteLine($"Manufacturing Date: {MfDate.ToShortDateString()}");
        Console.WriteLine($"Expiry Date: {ExpDate.ToShortDateString()}");
    }
}

class ProductProgram
{
    static void Main()
    {
        HerbalProduct herbalProduct = new HerbalProduct
        {
            Pid = 1,
            Pname = "Herbal Shampoo",
            Price = 10.99m,
            HerbsUsed = "Aloe Vera, Chamomile",
            MfDate = new DateTime(2023, 1, 1),
            ExpDate = new DateTime(2024, 12, 31)
        };

        herbalProduct.ShowDetails();
    }
}