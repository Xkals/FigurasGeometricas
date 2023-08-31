/* Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes figuras geométricas:
 cuadrado, rectángulo, triángulo y círculo. Mostrar en pantalla los valores calculados por cada figura geométrica */


namespace FigurasGeometricas
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Geométrica");

            while (true)   // Bucle
            {
                Console.WriteLine("\nElija una figura geométrica:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Círculo");
                Console.WriteLine("5. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularCuadrado();
                        break;
                    case 2:
                        CalcularRectangulo();
                        break;
                    case 3:
                        CalcularTriangulo();
                        break;                                                // Selección 
                    case 4:
                        CalcularCirculo();
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void CalcularCuadrado()
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double perimetro = 4 * lado;                                            // Perimetro 4 * Lados
            double area = lado * lado;                                              // Area es Lado Por lado

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
        }

        static void CalcularRectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * (baseRectangulo + alturaRectangulo);                    
            double area = baseRectangulo * alturaRectangulo;

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
        }

        static void CalcularTriangulo()
        {
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el primer lado del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo lado del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer lado del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            double perimetro = lado1 + lado2 + lado3;
            double area = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
        }

        static void CalcularCirculo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * Math.PI * radio;
            double area = Math.PI * radio * radio;

            Console.WriteLine($"Circunferencia: {perimetro}");
            Console.WriteLine($"Área: {area}");
        }
    }
}
