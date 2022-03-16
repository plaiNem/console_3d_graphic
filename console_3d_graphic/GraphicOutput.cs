using System;

namespace console_3d_graphic
{
    public class GraphicOutput
    {
        public int Width { get; }
        public int Height { get; }
        public float Aspect { get; }
        public float PixelAspect { get; }
        public float Fov { get; }
        public char[] Screen { get; private set; }

        public GraphicOutput(int width, int height, float fov)
        {
            this.Width = width;
            this.Height = height;
            this.Fov = fov;
            Aspect = (float)width / height;
            PixelAspect = 8.0f / 16.0f;
            Screen = new char[Width * Height];
        }

        public void Reset()
        {
            Console.SetCursorPosition(0, 0);
            Array.Fill(array: Screen, ' ');
        }
        public void Draw(Mesh mesh)
        {
            char[] meshScreen = mesh.Draw(this);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (meshScreen[i + j * Width] != 0)
                    {
                        Screen[i + j * Width] = meshScreen[i + j * Width];
                    }
                }
            }
            Console.WriteLine(Screen);
        }
    }
}
