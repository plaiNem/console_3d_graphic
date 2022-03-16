using System;

namespace console_3d_graphic
{
    public class Functions
    {
        public static float Limitation(float value, float min, float max) => Math.Max(Math.Min(value, max), min);
        public static float LengthV2(Vector2 a) => (float)Math.Sqrt(a.X * a.X + a.Y * a.Y);
        public static float LengthV3(Vector3 a) => (float)Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        public static Vector3 Norm(Vector3 a) => a / LengthV3(a);
        public static float ScalarProductV2(Vector2 a, Vector2 b) => (float)(a.X * b.X + a.Y * b.Y);
        public static float ScalarProductV3(Vector3 a, Vector3 b) => (float)(a.X * b.X + a.Y * b.Y + a.Z * b.Z);
        public static Vector3 Reflect(Vector3 cameraPosition, Vector3 rotationDegree) => cameraPosition - rotationDegree * (2 * ScalarProductV3(rotationDegree, cameraPosition));


        public static Vector2 Sphere(Vector3 cameraPosition, Vector3 cameraDirection, float radius)
        {
            float xAxis = ScalarProductV3(cameraPosition, cameraDirection);
            float hypotenuse = ScalarProductV3(cameraPosition, cameraPosition) - radius * radius;
            float zAxis = xAxis * xAxis - hypotenuse;
            if (zAxis < 0.0) return new Vector2(-1.0f, -1.0f);
            zAxis = (float)Math.Sqrt(zAxis);
            return new Vector2(-xAxis - zAxis, xAxis + zAxis);
        }
    }
}
