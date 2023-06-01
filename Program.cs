using EspacioCalculadora;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Calculadora

bool resp = true, resultado;
int operacion = 1, opcion, num1, num2;
Calculadora valor = new Calculadora(); //No olvidad inicializar con el constructor

while (resp) {
    Console.WriteLine("---Operacion N"+operacion+"---");
    Console.WriteLine("Seleccione la operacion que desea realizar");
    Console.WriteLine("1_Suma");
    Console.WriteLine("2_Resta");
    Console.WriteLine("3_Mulitplicacion");
    Console.WriteLine("4_Division");
    resultado = int.TryParse(Console.ReadLine(), out opcion);
    if (resultado) {
        if (opcion > 0 && opcion < 5) {
            Console.WriteLine("Escriba el primer numero a operar");
            resultado = int.TryParse(Console.ReadLine(), out num1);
            if (resultado) {
                Console.WriteLine("Escriba el segundo numero a operar");
                resultado = int.TryParse(Console.ReadLine(), out num2);
                if (resultado) {
                    switch(opcion) {
                        case 1:
                            valor.Sumar(num1);
                            valor.Sumar(num2);
                        break;
                        case 2:
                            valor.Sumar(num1);
                            valor.Restar(num2);
                        break;
                        case 3:
                            valor.Sumar(num1);
                            valor.Multiplicar(num2);
                        break;
                        case 4:
                            valor.Sumar(num1);
                            valor.Dividir(num2);
                        break;
                    }
                    Console.WriteLine("Resultado: "+valor.Resultado);
                } else {
                    Console.WriteLine("No se ingresaron numeros");
                }
            } else {
                Console.WriteLine("No se ingresaron numeros");
            }
        }
    }  else {
        Console.WriteLine("Numero de operacion ingresado no valido");
    }
    Console.WriteLine("Desea realizar otra operacion (SI:1/NO:0)");
    resultado = int.TryParse(Console.ReadLine(), out num1);
    if (resultado) {
        if (num1 == 0) {
            resp = false;
        }
    }
    operacion++;
    valor.Limpiar();
}