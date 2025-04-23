class Calculadora {

    public static void Main(String[] args) {

        Console.WriteLine("Hello, Im Brenda :)");
        Console.WriteLine("Ingrese un número: ");
        string numeroQueIngresoElUsuarioPorTeclado = Console.ReadLine();

        int numero;
        if (numeroQueIngresoElUsuarioPorTeclado == "") {
            numero = 0;
        } else {
            numero = int.Parse(numeroQueIngresoElUsuarioPorTeclado);
        }

        if (int.TryParse(numeroQueIngresoElUsuarioPorTeclado, out int numero2))
        {
            
        }
        else {
            Console.WriteLine("Formato inválido, ingrese un número");
        }

        Calculadora calculadora = new Calculadora();
        calculadora.sumar(numero, numero2);
        calculadora.restar(9,0);
        calculadora.multiplicar(9,0);
        calculadora.dividir(9,0);
    }

    void sumar(int a, int b) {
        int resultado = a + b;
        Console.WriteLine("La suma es: " + resultado);
    }

    void restar(int a, int b) {
        int resultado = a - b;
        Console.WriteLine("La resta es: " + resultado);
    }

    void multiplicar( int a, int b) {
        int resultado = a * b;
        Console.WriteLine("La multiplicación es: " + resultado);
    }

    void dividir ( int a, int b) { 
    if (b != 0){
            int resultado = a / b;
            Console.WriteLine("La división es: " + resultado);
        }
        else
        {
            Console.WriteLine("Error: la división no es permitida.");
        }
    }
}