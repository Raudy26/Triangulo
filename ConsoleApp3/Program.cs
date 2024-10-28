using System;

namespace Polimorfismo
{
    // Clase abstracta
    abstract class Figura
    {
        public abstract double CalcularArea();
    }

    // Clase derivada: Rectángulo
    class Rectangulo : Figura
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }
    }

    // Clase derivada: Círculo
    class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    // Clase derivada: Triángulo
    class Triangulo : Figura
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de las figuras
            Figura rectangulo = new Rectangulo(5, 10);
            Figura circulo = new Circulo(7);
            Figura triangulo = new Triangulo(6, 4);

            // Calcular y mostrar el área de cada figura
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
        }
    }
}
