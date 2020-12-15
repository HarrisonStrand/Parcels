namespace Parcel.Models
{

  public class ParcelCalc
  {

    public int BoxLength { get; set; }
    public int BoxWidth { get; set; }
    public int BoxHeight { get; set; }
    public int BoxWeight { get; set; }

    public int Volume()
    {
      return BoxLength * BoxWidth * BoxHeight; 
    }

    public int ShipPrice()
    {
      int CubicFeet = Volume();
      if (CubicFeet < 3)
      {
        return CubicFeet * .18;
      }
      else if (CubicFeet > 3 && < 8)
      {
        return CubicFeet * .22;
      }
      else if (CubicFeet > 8)
      {
        return Cubic Feet * .3;
      }
      else 
      {
        return "how many bodies do you have in there?";
      }
    }

  }
}