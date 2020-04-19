using System;
namespace Contract
{
    public abstract class Shape
    {
        protected IRenderer Renderer;

        public string Color;

        public Shape(IRenderer rendered)
        {
            Renderer = rendered;
        }

        public abstract void DrawShape();
    }
}
