namespace EncapsulationDemoCSharp_55;

public class Person
{
    //properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    //fields
    private double _wallet;
    
    //methods (public) that access the private member
    public void AddFunds(double funds)
    {
        _wallet += funds;
    }

    public double CheckFunds()
    {
        return _wallet;
    }
}