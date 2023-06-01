using EspacioCalculadora;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Calculadora

bool resp = true, resultado;
int operacion = 1, opcion;
double num2;
Calculadora valor = new Calculadora(); //No olvidad inicializar con el constructor

while (resp) {
    Console.WriteLine("---Operacion N"+operacion+"---");
    Console.WriteLine("Seleccione la operacion que desea realizar");
    Console.WriteLine("1_Suma");
    Console.WriteLine("2_Resta");
    Console.WriteLine("3_Mulitplicacion");
    Console.WriteLine("4_Division");
    Console.WriteLine("5_Limpiar");
    resultado = int.TryParse(Console.ReadLine(), out opcion);
    if (resultado) {
        if (opcion > 0 && opcion < 6) {
            if (opcion != 5) {
                Console.WriteLine("Escriba numero a operar");
                resultado = double.TryParse(Console.ReadLine(), out num2);
            } else {
                num2 = 0;
                resultado = true;
            }
            if (resultado) {
                switch(opcion) {
                    case 1:
                        valor.Sumar(num2);
                    break;
                    case 2:
                        valor.Restar(num2);
                    break;
                    case 3:
                        valor.Multiplicar(num2);
                    break;
                    case 4:
                        valor.Dividir(num2);
                    break;
                    case 5:
                        valor.Limpiar();
                    break;
                }
                Console.WriteLine("Resultado: "+valor.Resultado);
            } else {
                Console.WriteLine("No se ingresaron numeros");
            }
        } else {
            Console.WriteLine("No se ingresaron numeros");
        }
    }  else {
        Console.WriteLine("Numero de operacion ingresado no valido");
    }
    Console.WriteLine("Desea realizar otra operacion (SI:1/NO:0)");
    resultado = double.TryParse(Console.ReadLine(), out num2);
    if (resultado) {
        if (num2 == 0) {
            resp = false;
        }
    }
    operacion++;

}