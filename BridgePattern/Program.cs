using Contract;
using Core;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorRenderer vr = new VectorRenderer();
            NonvectorRenderer nvr = new NonvectorRenderer();

            Shape sline = new Line(vr, "RED");

            sline.DrawShape();

            sline = new Line(nvr, "Green");

            sline.DrawShape();
        }
    }
}
