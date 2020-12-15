namespace Parcel.Models
{

  public class ParcelCalc
  {

    public int BoxLength { get; set; }
    public int BoxWidth { get; set; }
    public int BoxHeight { get; set; }
    public int BoxWeight { get; set; }


    public double Volume()
    {
      
      return BoxLength * BoxWidth * BoxHeight; 
    }

    public double ShipPrice()
    {
      double CubicFeet = Volume();
      if (CubicFeet < 3)
      {
        return CubicFeet * BoxWeight * .18;
      }
      else if (CubicFeet > 3 && CubicFeet < 8)
      {
        return CubicFeet * BoxWeight * .22;
      }
      else if (CubicFeet > 8)
      {
        return CubicFeet * BoxWeight * .3;
      }
      return 0;
    }
  }
}