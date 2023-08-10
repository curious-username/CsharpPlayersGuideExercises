

Rectangle r = new Rectangle(5,2);


Console.WriteLine(r.Area);

public class Rectangle
{
    public float Width { set; get; }
    public float Height { set; get; }
    public float Area => Width * Height;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }
}




//public class Rectangle
//{
//    private float _width;
//    private float _height;
//    private float _area;

//    public Rectangle(float width, float height)
//    {
//        _width = width;
//        _height = height;
//    }

//    public float Width
//    {
//        get => _width;
//        set => _height = value;

//    }

//    public float Height
//    {
//        get => _height;
//        set => _height = value;
//    }
//    public float Area => _height * _width;
//}