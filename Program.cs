// using EspacioCalculadora;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Calculadora

// bool resp = true, resultado;
// int operacion = 1, opcion;
// double num;
// Calculadora valor = new Calculadora(); //No olvidad inicializar con el constructor

// while (resp) {
//     Console.WriteLine("---Operacion N"+operacion+"---");
//     Console.WriteLine("Seleccione la operacion que desea realizar");
//     Console.WriteLine("1_Suma");
//     Console.WriteLine("2_Resta");
//     Console.WriteLine("3_Mulitplicacion");
//     Console.WriteLine("4_Division");
//     Console.WriteLine("5_Limpiar");
//     resultado = int.TryParse(Console.ReadLine(), out opcion);
//     if (resultado) {
//         if (opcion > 0 && opcion < 6) {
//             if (opcion != 5) {
//                 Console.WriteLine("Escriba numero a operar");
//                 resultado = double.TryParse(Console.ReadLine(), out num);
//             } else {
//                 num = 0;
//                 resultado = true;
//             }
//             if (resultado) {
//                 switch(opcion) {
//                     case 1:
//                         valor.Sumar(num);
//                     break;
//                     case 2:
//                         valor.Restar(num);
//                     break;
//                     case 3:
//                         valor.Multiplicar(num);
//                     break;
//                     case 4:
//                         valor.Dividir(num);
//                     break;
//                     case 5:
//                         valor.Limpiar();
//                     break;
//                 }
//                 Console.WriteLine("Resultado: "+valor.Resultado);
//             } else {
//                 Console.WriteLine("No se ingresaron numeros");
//             }
//         } else {
//             Console.WriteLine("No se ingresaron numeros");
//         }
//     }  else {
//         Console.WriteLine("Numero de operacion ingresado no valido");
//     }
//     Console.WriteLine("Desea realizar otra operacion (SI:1/NO:0)");
//     resultado = double.TryParse(Console.ReadLine(), out num);
//     if (resultado) {
//         if (num == 0) {
//             resp = false;
//         }
//     }
//     operacion++;
// }

using EspacioEmpleado;
string nombre, apellido;
char genero, estadoCivil;
double sueldoBasico;
DateTime fechaNacimiento, fechaIngreso;
Cargos cargo;
nombre = "Jose";
apellido = "Boggio";
genero = 'M';
estadoCivil = 'S';
sueldoBasico = 25000;
fechaNacimiento = new DateTime(1994, 1, 9);
fechaIngreso = new DateTime(2010, 12, 19);
cargo = Cargos.Administrativo;

Empleado empleado1 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

nombre = "Facundo";
apellido = "Ment";
genero = 'M';
estadoCivil = 'C';
sueldoBasico = 200000;
fechaNacimiento = new DateTime(1974, 10, 29);
fechaIngreso = new DateTime(2000, 1, 1);
cargo = Cargos.Ingeniero;
Empleado empleado2 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

nombre = "Valentina";
apellido = "Quiroga";
genero = 'F';
estadoCivil = 'C';
sueldoBasico = 150000;
fechaNacimiento = new DateTime(1983, 7, 23);
fechaIngreso = new DateTime(1999, 5, 3);
cargo = Cargos.Especialista;

Empleado empleado3 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

List<Empleado> listaEmpleados = new List<Empleado>();
listaEmpleados.Add(empleado1);
listaEmpleados.Add(empleado2);
listaEmpleados.Add(empleado3);

double montoTotal = empleado1.CalcularSalario() + empleado2.CalcularSalario() + empleado3.CalcularSalario();

foreach (var empleado in listaEmpleados)
{
    montoTotal += empleado.CalcularSalario();
    empleado.MostrarEmpleado();
}
Console.WriteLine("El monto total a pagar por salarios es $"+montoTotal);
Empleado jubilado = empleado1;

foreach (var empleado in listaEmpleados)
{
    if(jubilado.CantidadAnios() > empleado.CantidadAnios()){
        jubilado = empleado;
    }
}
Console.WriteLine("El empleado mas cerca a jubilarse es: ");
jubilado.MostrarEmpleado();