using System;
using Contract;

namespace Core
{
    public class NonvectorRenderer : IRenderer
    {
        public NonvectorRenderer()
        {
        }

        public void Render(string shapeName, string color)
        {
            Console.WriteLine($"Non Vector Renderer rendering Shape {shapeName} and with color {color}");
        }
    }
}
