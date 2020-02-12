using System;

namespace Types
{
    // FLOAT

    public class Vector2f
    {
        public float x;
        public float y;

        public Vector2f(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }

    public class Vector3f
    {
        public float x;
        public float y;
        public float z;

        public Vector3f(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }

    // INT

    public class Vector2i
    {
        public int x;
        public int y;

        public Vector2i(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    public class Vector3i
    {
        public int x;
        public int y;
        public int z;

        public Vector3i(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
}
