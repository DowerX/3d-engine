using System;
using System.Collections.Generic;
using Types;
using System.IO;

namespace Wavefront
{
    public class OBJ
    {
        public List<Vector3f> vertices = new List<Vector3f>();
        public List<Vector3f> normalCoordinates = new List<Vector3f>();
        public List<Vector2f> textureCoordinates = new List<Vector2f>();
        public List<Vector3i> faces = new List<Vector3i>();
    }

    public class Wavefront
    {
        public OBJ LoadOBJ(string path)
        {
            string[] file;

            try
            {
               file = File.ReadAllLines(path);
            }
            catch
            {
                Console.WriteLine("Error: Can't read obj file: '" + path + "'.");
                return null;
            }

            OBJ obj = new OBJ();

            foreach (string line in file)
            {
                string[] parts = line.Split(' ');
                switch (parts[0]){
                    case "v":

                        break;
                }
            }

            return null;
        }
    }
}
