namespace console_3d_graphic
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2()
        {
            X = 0;
            Y = 0;
        }

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b) => new (){ X = a.X + b.X, Y = a.Y + b.Y };
        public static Vector2 operator -(Vector2 a, Vector2 b) => new (){ X = a.X - b.X, Y = a.Y - b.Y };
        public static Vector2 operator *(Vector2 a, Vector2 b) => new (){ X = a.X * b.X, Y = a.Y * b.Y };
        public static Vector2 operator /(Vector2 a, Vector2 b) => new(){ X = a.X / b.X, Y = a.Y / b.Y };


        public static Vector2 operator +(Vector2 a, float b) => new (){ X = a.X + b, Y = a.Y + b };
        public static Vector2 operator -(Vector2 a, float b) => new (){ X = a.X - b, Y = a.Y - b };
        public static Vector2 operator *(Vector2 a, float b) => new (){ X = a.X * b, Y = a.Y * b };
        public static Vector2 operator /(Vector2 a, float b) => new (){ X = a.X / b, Y = a.Y / b };

        
    }
}

