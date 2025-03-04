namespace EncapsulationDemoCSharp_55;

class Program
{
    static void Main(string[] args)
    {
        var seth = new Person();
        seth.Name = "Seth";
        seth.Age = 30;
        
        //cannot access private members outside of the class they exist in
        //seth._wallet
        
        //call public methods that access the private member
        Console.WriteLine($"Current Funds: {seth.CheckFunds()}");
        
        seth.AddFunds(500.50);
        
        Console.WriteLine($"Current Funds: {seth.CheckFunds()}");
    }
}
