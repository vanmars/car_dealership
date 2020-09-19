namespace Dealership.Models
{
  public class Car
  {
    // Object Fields (should be set to private)
    private string _makeModel;
    private int _price;
    private int _miles;

    // Property
    public string akeModel
    {
      get
      {
        return _makeModel;
      }
      set
      {
        _makeModel = value;
      }
    }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    // Getters
    public string GetMakeModel()
    {
      return _makeModel;
    }

   public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    // Setters
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    // Max Price Method
    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }

     // Static Methods
    public static string MakeSound(string sound)
    {
      return "Our cars mnake the following sound: " + sound;
    }

    public static string MakeSmell(string smell)
    {
      return "Our cars smell like " + smell;
    }
  }
}