using System;
using System.Collections.Generic;


class Cars
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private bool _isUsed;
  private string _carMessage;

  public Cars(string makeModel, int carPrice, int carMile, bool carUsed=true)
  {
    _makeModel = makeModel;
    _price = carPrice;
    _miles = carMile;
    _isUsed = carUsed;
  }

  public bool WorthBuying(int maxPrice)
  {
    return _price < (maxPrice + 100);
  }

  public void setMakeModel(string MakeModel)
  {
    _makeModel = MakeModel;
  }
  public string getMakeModel()
  {
    return _makeModel;
  }
  public void setPrice(int Price)
  {
    _price = Price;
  }
  public int getPrice()
  {
    return _price;
  }
  public void setMiles(int Mile)
  {
    _miles = Mile;
  }
  public int getMiles()
  {
    return _miles;
  }
  public void setUsed (bool used)
  {
    _isUsed = used;
  }
  public bool getUsed()
  {
    return _isUsed;
  }

  public string getCarMessage()
  {
    return _carMessage;
  }
  public void setCarMessage(string message)
  {
    _carMessage = message;
  }

}

public class Program
{
  public static void Main()
  {

    Cars porsche = new Cars("2014 Porsche 911", 114991, 7864);

    Cars ford = new Cars("2011 Ford F450", 55995, 14241);

    Cars lexus = new Cars("2013 Lexus RX 350", 44700, 20000);

    Cars mercedes = new Cars("Mercedes Benz CLS550", 39900, 37979);

    mercedes.setCarMessage("This car only has 1 previous owner!!!");

    List<Cars> Cars = new List<Cars>() {porsche, ford, lexus, mercedes};

    Console.WriteLine("Enter a maximum price!");
    string stringMaxPrice= Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    // Console.WriteLine("Enter a maximum miles!");
    // string stringMaxMiles = Console.ReadLine();
    // int maxMiles = int.Parse(stringMaxMiles);


    List<Cars> CarsMatchingSearch = new List<Cars>(0);

    //
    // foreach (Cars automobile in Cars)
    // {
    //   if (automobile.getPrice() < maxPrice && automobile.getMiles() < maxMiles)
    //   {
    //     CarsMatchingSearch.Add(automobile);
    //   }
    // }
    foreach (Cars automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine(CarsMatchingSearch.Count + "string wbal");
      Console.WriteLine("the count is {0}", CarsMatchingSearch.Count);
      Console.WriteLine("You have no matching results!!!");
    }
    else
    {
      foreach (Cars automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.getMakeModel() + " " + automobile.getCarMessage());
      }
    }
  }
}
