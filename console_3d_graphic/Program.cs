using System;


namespace console_3d_graphic
{
    class Program
    {
        static void Main()
        {
            GraphicOutput graphicOutput = new(100, 50, 0.7f);
            Sphere sphere = new (new Vector2(0, 0), 0.7f);
            while (true)
            {
                graphicOutput.Reset();
                graphicOutput.Draw(sphere);
                Sphere.Сoefficient++;
            }
        }
    }
}
