namespace Contract
{
    public abstract class Shape
    {
        protected readonly IRenderer Renderer;

        protected string Color;

        protected Shape(IRenderer rendered)
        {
            Renderer = rendered;
        }

        public abstract void DrawShape();
    }
}
