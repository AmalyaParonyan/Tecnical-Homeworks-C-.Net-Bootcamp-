using System;

class program3{
    public void Area(int length, int width){
        Console.WriteLine("Area -> " + (width * length));
    }

    public void Volume(int length, int width, int height)
    {
        Console.WriteLine("Volume -> " + (width * length * height));
    }
    static void Main(string[] args) {
        program3 Examle= new program3();
        Examle.Area(5, 5);
        Examle.Volume(5, 5, 3);
    }
 }
