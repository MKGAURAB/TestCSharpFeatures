namespace Core
{
    using Contract;

    public class Line : Shape
    {
        public Line(IRenderer rendered, string color) : base(rendered)
        {
            Color = color;
        }

        public override void DrawShape()
        {
            Renderer.Render(this.GetType().Name, Color);
        }
    }
}
