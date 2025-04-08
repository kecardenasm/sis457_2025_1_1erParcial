using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib_2
{
    public abstract class FiguraGeometrica
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }

    public class Triangulo : FiguraGeometrica
    {
        private readonly decimal _base;
        private readonly decimal altura;

        public Triangulo(decimal base_, decimal altura)
        {
            _base = base_;
            this.altura = altura;
        }

        public override decimal area()
        {
            return (_base * altura) / 2;
        }
        public override decimal perimetro()
        {
            return _base + altura + (decimal)Math.Sqrt(Math.Pow((double)_base, 2) + Math.Pow((double)altura, 2));
        }
    }

    public class Circulo : FiguraGeometrica
    {
        private readonly decimal radio;
        public Circulo(decimal radio)
        {
            this.radio = radio;
        }
        public override decimal area()
        {
            return (decimal)Math.PI * radio * radio;
        }
        public override decimal perimetro()
        {
            return 2 * (decimal)Math.PI * radio;
        }
    }
}
