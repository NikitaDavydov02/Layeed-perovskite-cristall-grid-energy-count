using System;
using System.Collections.Generic;
using System.Text;

namespace Расчёт_энергии_решётки_слоистого_перовскита
{
    public struct Vector3
    {
        public double x;
        public double y;
        public double z;
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public static class VectorMath
    {
        public static Vector3 Sum(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3 Scalar(double k, Vector3 a)
        {
            return new Vector3(a.x * k, a.y * k, a.z * k);
        }
        public static double Magnitude(Vector3 v)
        {
            return (double)Math.Sqrt((v.x * v.x) + (v.y * v.y) + (v.z * v.z));
        }
        public static Vector3 Difference(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3 ClampMagnitude(Vector3 v, double magnitude)
        {
            if (v.x != 0)
            {
                double a = v.y / v.x;
                double b = v.z / v.x;
                double x = magnitude / ((double)Math.Sqrt(1 + a * a + b * b));
                double y = a * x;
                double z = b * x;
                if (v.x * x < 0)
                    x = -x;
                if (v.y * y < 0)
                    y = -y;
                if (v.z * z < 0)
                    z = -z;
                return new Vector3(x, y, z);
            }
            else if (v.y != 0)
            {
                double a = v.x / v.y;
                double b = v.z / v.y;
                double y = magnitude / ((double)Math.Sqrt(1 + a * a + b * b));
                double x = a * y;
                double z = b * y;
                if (v.x * x < 0)
                    x = -x;
                if (v.y * y < 0)
                    y = -y;
                if (v.z * z < 0)
                    z = -z;
                return new Vector3(x, y, z);
            }
            else if (v.z != 0)
            {
                double a = v.y / v.z;
                double b = v.x / v.z;
                double z = magnitude / ((double)Math.Sqrt(1 + a * a + b * b));
                double y = a * z;
                double x = b * z;
                if (v.x * x < 0)
                    x = -x;
                if (v.y * y < 0)
                    y = -y;
                if (v.z * z < 0)
                    z = -z;
                return new Vector3(x, y, z);
            }
            else
                return new Vector3(0, 0, 0);
        }
        public static bool Equals(Vector3 a, Vector3 b)
        {
            if (a.x == b.x && a.y == b.y && a.z == b.z)
                return true;
            else
                return false;
        }
    }
}
