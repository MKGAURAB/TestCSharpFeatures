namespace Core
{
    using System;
    using Contract;

    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeName, string color)
        {
            Console.WriteLine($"Vector Renderer rendering Shape {shapeName} and with color {color}");
        }
    }
}
