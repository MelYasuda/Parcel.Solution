namespace Parcels.Models
{
  public class Parcel
  {
    private int _height;
    private int _length;
    private int _width;
    private int _weight;

    public Parcel(int height, int width, int length, int weight)
    {
      _height = height;
      _width = width;
      _length = length;
      _weight = weight;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }
    public int GetWeight()
    {
      return _weight;
    }

    public int Volume()
    {
      return this.GetHeight() * this.GetLength() * this.GetWidth();
    }

    public int CostToShip()
    {
      return this.Volume() * 2 + 8;
    }

  }
}
