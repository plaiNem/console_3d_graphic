using System;

namespace console_3d_graphic
{
    public class Mesh
    {
        protected Vector2 position;

        public Mesh(Vector2 position)
        {
            this.position = position;
        }

        public void SetPosition(Vector2 newPosition)
        {
            position = newPosition;
        }

        public Vector2 GetPosition()
        {
            return position;
        }
        public void Move(Vector2 direction)
        {
            position += direction;
        }
        public virtual char[] Draw(GraphicOutput graphicOutput)
        {
            return new char[graphicOutput.Width * graphicOutput.Height];
        }
    }

    class Sphere : Mesh
    {
        protected float size;
        public Sphere(Vector2 position, float size) : base(position) => this.size = size;

        public static int Сoefficient { get; internal set; }

        override public char[] Draw(GraphicOutput graphicOutput)
        {
            char[] screen = new char[graphicOutput.Screen.Length];

            for (int i = 0; i < graphicOutput.Width; i++)
            {
                for (int j = 0; j < graphicOutput.Height; j++)
                {
                    Vector2 uv = new Vector2((float)i, (float)j) / new Vector2(graphicOutput.Width, graphicOutput.Height) * 2.0f * graphicOutput.Fov - 1.0f * graphicOutput.Fov;
                    uv *= -graphicOutput.Aspect * graphicOutput.PixelAspect * size;
                    
                    Vector3 light = Functions.Norm(new Vector3((float)Math.Sin(Сoefficient * 0.01f), (float)Math.Cos(Сoefficient * 0.01f), 0.4f));
                    Vector3 cameraPosition = new(-6, 0, 0);
                    Vector3 cameraDirection = Functions.Norm(new(2, uv.X, uv.Y));
                    Vector2 intersection = Functions.Sphere(cameraPosition, cameraDirection, 1);
                    Vector3 rotationDegree = Functions.Norm(cameraPosition + cameraDirection * intersection.X);//n
                    float differnce = Functions.ScalarProductV3(rotationDegree, light);

                    if (intersection.X > 0)
                    {
                        char[] gradient = { ' ', '.', ':', '!', '/', 'r', '(', 'l', '1', 'Z', '4', 'H', '9', 'W', '8', '$', '@' };
                        int color = (int)(differnce * 30);
                        color = (int)Functions.Limitation(color, 0, gradient.Length - 2);
                        char pixel = gradient[color];
                        screen[i + j * graphicOutput.Width] = pixel;
                    }
                }
            }
            return screen;
        }
    }
}