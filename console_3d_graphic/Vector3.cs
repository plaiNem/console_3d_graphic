namespace console_3d_graphic
{
    public class Vector3
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public Vector3()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public static Vector3 operator +(Vector3 a, Vector3 b) => new (){ X = a.X + b.X, Y = a.Y + b.Y, Z = a.Z + b.Z};
        public static Vector3 operator -(Vector3 a, Vector3 b) => new(){ X = a.X - b.X, Y = a.Y - b.Y, Z = a.Z - b.Z };
        public static Vector3 operator *(Vector3 a, Vector3 b) => new(){ X = a.X * b.X, Y = a.Y * b.Y, Z = a.Z * b.Z };
        public static Vector3 operator /(Vector3 a, Vector3 b) => new(){ X = a.X / b.X, Y = a.Y / b.Y, Z = a.Z / b.Z };


        public static Vector3 operator +(Vector3 a, float b) => new(){ X = a.X + b, Y = a.Y + b, Z = a.Z + b };
        public static Vector3 operator - (Vector3 a, float b) => new(){ X = a.X - b, Y = a.Y - b, Z = a.Z - b };
        public static Vector3 operator *(Vector3 a, float b) => new(){ X = a.X * b, Y = a.Y * b, Z = a.Z * b };
        public static Vector3 operator /(Vector3 a, float b) => new(){ X = a.X / b, Y = a.Y / b, Z = a.Z / b };        
    }
}

