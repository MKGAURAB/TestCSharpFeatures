namespace Core
{
    using System;
    using Contract;

    public class NonvectorRenderer : IRenderer
    {
        public void Render(string shapeName, string color)
        {
            Console.WriteLine($"Non Vector Renderer rendering Shape {shapeName} and with color {color}");
        }
    }
}
