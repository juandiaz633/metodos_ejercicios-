// Ejercicio #1: Sumar dos números
static void SumarDosNumeros()
{
    int n1, n2;

    Console.WriteLine("Ingrese el primer número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número: ");
    n2 = int.Parse(Console.ReadLine());

    int suma = n1 + n2;

    Console.WriteLine("La suma de los números es {0}", suma);
}

// Ejercicio #2: Mostrar la capital de un país
static void MostrarCapital()
{
    string pais, capital;

    Console.WriteLine("Ingrese el país: ");
    pais = Console.ReadLine();

    Console.WriteLine("Ingrese la capital: ");
    capital = Console.ReadLine();

    Console.WriteLine("{0} es la capital de {1}", capital, pais);
}

// Ejercicio #3: Calcular el doble y el triple de un número
static void CalcularDobleYTriple()
{
    double numero1;

    Console.WriteLine("Ingrese un número: ");
    numero1 = double.Parse(Console.ReadLine());

    double doble = numero1 * 2;
    double triple = numero1 * 3;

    Console.WriteLine("El doble del número es {0}", doble);
    Console.WriteLine("El triple del número es {0}", triple);
}

// Ejercicio #4: Calcular el cuadrado y el cubo de un número
static void CalcularCuadradoYCubo()
{
    int numero2, cuadrado2, cubo2;

    Console.WriteLine("Ingrese un número: ");
    numero2 = int.Parse(Console.ReadLine());

    cuadrado2 = numero2 * numero2;
    cubo2 = numero2 * numero2 * numero2;

    Console.WriteLine("El cuadrado del número es {0}", cuadrado2);
    Console.WriteLine("El cubo del número es {0}", cubo2);
}

// Ejercicio #5: Calcular el número siguiente
static void CalcularNumeroSiguiente()
{
    double numero3;

    Console.WriteLine("Ingrese un número: ");
    numero3 = double.Parse(Console.ReadLine());

    double siguiente = numero3 + 1;

    Console.WriteLine("El número siguiente es {0}", siguiente);
}

// Ejercicio #6: Generar un número aleatorio y aumentarlo en un 30%
static void GenerarNumeroAleatorioYAumentar()
{
    int numero4 = new Random().Next(0, 201);

    Console.WriteLine("El número aleatorio es: {0}", numero4);

    int numeroAumentado = (int)(numero4 * 1.3);

    Console.WriteLine("El número aumentado en un 30% es: {0}", numeroAumentado);
}
// Ejercicio #7: Generar un número aleatorio y disminuirlo en un 15%
static void GenerarNumeroAleatorioYDisminuir()
{
    double numero5 = new Random().NextDouble(0.10, 51.00);

    Console.WriteLine("El número aleatorio es: {0}", numero5);

    double numeroDisminuido = numero5 * 0.85;

    Console.WriteLine("El número disminuido en un 15% es: {0}", numeroDisminuido);
}

// Ejercicio #8: Calcular el promedio de tres números
static void CalcularPromedio()
{
    double numero1_1, numero2_2, numero3_3;

    Console.WriteLine("Ingrese el primer número: ");
    numero1_1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número: ");
    numero2_2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer número: ");
    numero3_3 = double.Parse(Console.ReadLine());

    double promedio = (numero1_1 + numero2_2 + numero3_3) / 3;

    Console.WriteLine("El promedio es: {0}", promedio);
}

// Ejercicio #9: Intercambiar dos palabras
static void IntercambiarPalabras()
{
    string palabraA, palabraB, temp;

    Console.WriteLine("Ingrese la primera palabra: ");
    palabraA = Console.ReadLine();

    Console.WriteLine("Ingrese la segunda palabra: ");
    palabraB = Console.ReadLine();

    temp = palabraA;
    palabraA = palabraB;
    palabraB = temp;

    Console.WriteLine("La palabra A es ahora: {0}", palabraA);
    Console.WriteLine("La palabra B es ahora: {0}", palabraB);
}

// Ejercicio #10: Calcular el área y el perímetro de un rectángulo
static void CalcularAreaYPerimetroRectangulo()
{
    int base1, altura;

    Console.WriteLine("Ingrese la base del rectángulo: ");
    base1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la altura del rectángulo: ");
    altura = int.Parse(Console.ReadLine());

    int area = base1 * altura;
    int perimetro = 2 * (base1 + altura);

    Console.WriteLine("El área del rectángulo es: {0}", area);
    Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
}

// Ejercicio #11: Calcular el volumen de un cilindro
static void CalcularVolumenCilindro()
{
    double radio, altura2, volumen;

    Console.WriteLine("Ingrese el radio del cilindro: ");
    radio = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la altura del cilindro: ");
    altura2 = double.Parse(Console.ReadLine());

    volumen = Math.PI * radio * radio * altura2;

    Console.WriteLine("El volumen del cilindro es: {0}", volumen);
}

// Ejercicio #12: Convertir centímetros a otras unidades de longitud
static void ConvertirCentimetros()
{
    double cm = double.Parse(Console.ReadLine());

    double conversionyd = cm / 91.44;
    double conversionmt = cm / 100;
    double conversionps = cm / 30.48;
    double conversionpg = cm / 2.54;

    Console.WriteLine("Yardas: " + conversionyd);
    Console.WriteLine("Metros: " + conversionmt);
    Console.WriteLine("Pies: " + conversionps);
    Console.WriteLine("Pulgadas: " + conversionpg);
}

// Ejercicio #13: Convertir grados Fahrenheit a Celsius
static void ConvertirFahrenheitACelsius()
{
    Console.WriteLine("Algoritmo para transformar temperatura Fahrenheit a Celsius");
    Console.Write("Añade la temperatura Fahrenheit: ");

    double fh = Convert.ToDouble(Console.ReadLine());
    double conversionfh = (fh - 32) * 5 / 9;

    Console.WriteLine("El grado Fahrenheit convertido a grados Celsius es: " + conversionfh);
}

// Ejercicio #14: Calcular el volumen de un cilindro
static void CalcularVolumenCilindro2()
{
    double radio3, altura3, volumen3;

    Console.WriteLine("Ingrese el radio del cilindro: ");
    radio3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la altura del cilindro: ");
    altura3 = double.Parse(Console.ReadLine());

    if (radio3 <= 0)
    {
        Console.WriteLine("El radio debe ser positivo.");
        return;
    }

    if (altura3 <= 0)
    {
        Console.WriteLine("La altura debe ser positiva.");
        return;
    }

    volumen3 = Math.PI * radio3 * radio3 * altura3;

    Console.WriteLine("El volumen del cilindro es: {0}", volumen3);
}

// Ejercicio #15: Verificar si un número es divisible
static void VerificarDivisibilidad()
{
    int n1, n2;

    Console.WriteLine("Ingrese el primer número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número: ");
    n2 = int.Parse(Console.ReadLine());

    int residuo = n1 % n2;

    if (residuo == 0)
    {
        Console.WriteLine("Es divisible");
    }
    else
    {
        Console.WriteLine("No es divisible");
    }
}

// Ejercicio #16: Calcular el porcentaje de hombres y mujeres
static void CalcularPorcentajeHombresMujeres()
{
    int hombres, mujeres;

    Console.WriteLine("Ingrese el total de hombres: ");
    hombres = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el total de mujeres: ");
    mujeres = int.Parse(Console.ReadLine());

    int total = hombres + mujeres;
    double porcentajeHombres = (double)hombres / total * 100;
    double porcentajeMujeres = (double)mujeres / total * 100;

    Console.WriteLine("El porcentaje de hombres es: {0}%", porcentajeHombres);
    Console.WriteLine("El porcentaje de mujeres es: {0}%", porcentajeMujeres);
}

// Ejercicio #17: Determinar si un número es positivo, negativo o nulo
static void DeterminarPositivoNegativoNulo()
{
    int numero;

    Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("El número es negativo");
    }
    else if (numero > 0)
    {
        Console.WriteLine("El número es positivo");
    }
    else
    {
        Console.WriteLine("El número es nulo");
    }
}

// Ejercicio #18: Encontrar el mayor de tres números
static void EncontrarMayor()
{
    int nu1, nu2, nu3;

    Console.WriteLine("Ingrese el primer número: ");
    nu1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número: ");
    nu2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer número: ");
    nu3 = int.Parse(Console.ReadLine());

    int mayor = nu1;

    if (nu2 > mayor)
    {
        mayor = nu2;
    }

    if (nu3 > mayor)
    {
        mayor = nu3;
    }

    Console.WriteLine("El mayor número es: {0}", mayor);
}

// Ejercicio #19: Identificar el tipo de triángulo
static void IdentificarTriangulo()
{
    int lado1, lado2, lado3;

    Console.WriteLine("Ingrese el primer lado: ");
    lado1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo lado: ");
    lado2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer lado: ");
    lado3 = int.Parse(Console.ReadLine());

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("El triángulo es equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("El triángulo es isósceles");
    }
    else
    {
        Console.WriteLine("El triángulo es escaleno");
    }
}

// Ejercicio #20: Determinar la docena en la ruleta
static void DeterminarDocenaRuleta()
{
    int resultado = int.Parse(Console.ReadLine());

    if (resultado >= 1 && resultado <= 12)
    {
        Console.WriteLine("Docena: Primera");
    }
    else if (resultado >= 13 && resultado <= 24)
    {
        Console.WriteLine("Docena: Segunda");
    }
    else if (resultado >= 25 && resultado <= 36)
    {
        Console.WriteLine("Docena: Tercera");
    }
    else
    {
        Console.WriteLine("Error: El resultado no es válido");
    }
}

// Ejercicio #21: Contar los dígitos de un número
static void ContarDigitos()
{
    int numero21;
    int digitos = 0;

    Console.WriteLine("Ingrese un número: ");
    numero21 = int.Parse(Console.ReadLine());

    while (numero21 > 0)
    {
        digitos++;
        numero21 /= 10;
    }

    Console.WriteLine("La cantidad de dígitos es: {0}", digitos);
}

// Ejercicio #22: Descomponer un número en sus dígitos
static void DescomponerDigitos()
{
    int numero22;
    int digitoActual;
    int indiceDigitoActual;

    Console.WriteLine("Ingrese un número: ");
    numero22 = int.Parse(Console.ReadLine());

    indiceDigitoActual = 0;

    while (numero22 > 0)
    {
        digitoActual = numero22 % 10;
        Console.WriteLine("d{0} = {1}", indiceDigitoActual, digitoActual);
        indiceDigitoActual++;
        numero22 /= 10;
    }
}

// Ejercicio #23: Sumar los dígitos de un número
static void SumarDigitos()
{
    int numero23;
    int digitoActual2;
    int indiceDigitoActual2;
    int sumaDigitos = 0;

    Console.WriteLine("Ingrese un número: ");
    numero23 = int.Parse(Console.ReadLine());

    indiceDigitoActual2 = 0;

    while (numero23 > 0)
    {
        digitoActual2 = numero23 % 10;
        sumaDigitos += digitoActual2;
        Console.WriteLine("d{0} = {1}", indiceDigitoActual2, digitoActual2);
        indiceDigitoActual2++;
        numero23 /= 10;
    }

    Console.WriteLine("La suma de los dígitos es: {0}", sumaDigitos);
}

// Ejercicio #24: Verificar si un número es divisible y menor o igual a 25
static void VerificarDivisibilidadYMenor()
{
    int numero24 = new Random().Next(1, 1000);

    if (numero24 % 5 == 0 && numero24 <= 25)
    {
        Console.WriteLine("Correcto");
    }
}

// Ejercicio #25: Comprobar si un número es capicúa
static void ComprobarCapicua()
{
    int numero25, reverso;

    Console.WriteLine("Ingrese un número de 5 dígitos: ");
    numero25 = int.Parse(Console.ReadLine());

    reverso = 0;
    for (int i = numero25; i > 0; i /= 10)
    {
        reverso = reverso * 10 + i % 10;
    }

    if (numero25 == reverso)
    {
        Console.WriteLine("Es capicúa");
    }
    else
    {
        Console.WriteLine("No es capicúa");
    }
}

// Ejercicio #26: Resolución de una ecuación cuadrática
static void ResolverEcuacionCuadratica()
{
    double a, b, c;

    Console.WriteLine("Ingrese el valor de a: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el valor de b: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el valor de c: ");
    c = double.Parse(Console.ReadLine());

    double discriminante = b * b - 4 * a * c;

    if (discriminante > 0)
    {
        double x1, x2;
        x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
        Console.WriteLine("La solución 1 es: {0}", x1);
        Console.WriteLine("La solución 2 es: {0}", x2);
    }
    else if (discriminante == 0)
    {
        double x;
        x = -b / (2 * a);
        Console.WriteLine("La solución es: {0}", x);
    }
    else
    {
        Console.WriteLine("La ecuación no tiene soluciones reales");
    }
}
