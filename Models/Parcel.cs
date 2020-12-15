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
  }
}