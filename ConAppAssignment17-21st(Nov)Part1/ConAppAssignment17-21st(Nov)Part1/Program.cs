using System;

class Product
{
    public int Pid { get; set; }
    public string Pname { get; set; }
    public decimal Price { get; set; }

    public void SetInformation(int pid, string pname, decimal price)
    {
        Pid = pid;
        Pname = pname;
        Price = price;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Product ID: {Pid}");
        Console.WriteLine($"Product Name: {Pname}");
        Console.WriteLine($"Price: {Price:C}");
    }
}

