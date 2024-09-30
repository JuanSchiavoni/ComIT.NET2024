using ComIT.Console;
using System;
//CLASE 1 VS

//string nombre = "Juanchi";
//int edad = 26;
//double precio = 15.3;
//bool estaNublado = true;
//char letra = 'S';
//DateTime dateTime = DateTime.Now;
//DateOnly fechaSola;
//TimeOnly horaSola;

//const string cintestaSaludo = "Buen día";

//string saludo;

//if (estaNublado)
//{
//    string apellido = "Schiavoni";
//    if (letra == 'S')
//    {
//        apellido = "Ramirez";
//    }
//saludo = "Hola " + nombre + " " + apellido + "!. Hoy no es un buen dia!";
//    saludo = $"Hola {nombre.ToUpper()} {apellido}!. Hoy no es un buen dia!";
//}
//else
//{
//    string apodo = "Pepe";
//saludo = "Hola " + nombre + " mi amigo " + apodo + "!. Que lindo dia es hoy!";
//    saludo = $"Hola {nombre} mi amigo {apodo}!. Que lindo dia es hoy!";
//}

//Console.WriteLine(saludo);

//Console.WriteLine($"Hola {nombre}! hoy es {(estaNublado ? "un feo dia" : "un hermoso dia")}");


//int num1 = 10;
//int num2 = 20;

//int suma = num1 + num2;
//Console.WriteLine($"La suma de {num1} + {num2} es igual a {suma:F3}");

//int producto = num1 * num2;
//Console.WriteLine(producto);

//num1++;
//Console.WriteLine(num1);

//num2--;
//Console.WriteLine(num2);

//num1 += 100;
//Console.WriteLine(num1);

//string operador = "exponencial";
//int resultado = 0;

//if (operador == "suma")
//{
//    resultado = num1 + num2;
//}
//else if (operador == "resta")
//{
//    resultado = num1 - num2;
//}
//else if (operador == "multi")
//{
//    resultado = num1 * num2;
//}
//else if (operador == "division")
//{
//    resultado = num1 / num2;
//}
//else
//{
//    resultado = -1;
//}

//Console.WriteLine($"El resultado de la {operador} es igual a {resultado}");

//Tarea!!!
// 1)
//int n = 10;
//n += 5;
//Console.WriteLine(n);
// 2)
//string f1 = "Hello";
//string f2 = "word!!";
//Console.WriteLine($"{f1} {f2}");


//CLASE 2 VS

//using Microsoft.VisualBasic;

//Console.WriteLine("WHILE");
//int n = 6;
//while (n <= 5)
//{
//    Console.WriteLine(n);
//    n++;
//}

//Console.WriteLine("DO WHILE");
//int n1 = 6;
//do
//{
//    Console.WriteLine(n1);
//    n1++;
//} while (n1 <= 5);


//Console.WriteLine("ARRAY");
//int[] nArray = new int[5];

//nArray[0] = 5;
//nArray[1] = 6;
//nArray[2] = 7;
//nArray[3] = 8;
//nArray[4] = 9;

//Console.WriteLine(nArray[0]);
//Console.WriteLine(nArray[1]);
//Console.WriteLine(nArray[2]);
//Console.WriteLine(nArray[3]);
//Console.WriteLine(nArray[4]);

//string[] texto = new string[5] { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
//string[] textoSimple = ["Uno", "Dos", "Cuatro", "Cinco"];

//Array.Resize(ref textoSimple, 10);


//Console.WriteLine("FOR");
//for (int i = 0; i < texto.Length; i++)
//{
//    Console.WriteLine($"Posición {i}: {texto[i]}");
//}

//for (int i = 0; i < nArray.Length; i++)
//{
//    Console.WriteLine($"Posición {i}: {nArray[i]}");
//}

//for (int i = 0; i < textoSimple.Length; i++)
//{
//    Console.WriteLine($"Posición {i}: {textoSimple[i]}");
//}

//Cuendo le ponemos ? a una variable significa que ademas de cualquier valor se le puede asignar null
//string?[] cadenaNull = new string?[5] { "Uno", "", null, "Cuatro", "Cinco" };


//Console.WriteLine("FOREACH");
//foreach (var item in texto)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in cadenaNull)
//{
//    if (item == null)
//    {
//        Console.WriteLine("Sin valor");
//    }
//    else
//    {
//        Console.WriteLine(item);
//    }

//    Console.WriteLine(item == null ? "Sin valor" : item);
//    Console.WriteLine(item ?? "Sin valor");
//     ?? sirve solo para los null, si es null imprime sin valor sino imprime item
//}


//PRACTICA
// 3)
//int o1 = 9;
//int o2 = 7;
//if (o1 == o2)
//{
//    //console.writeline($"{o1} y {o2} son iguales");
//}else if (o1 < o2)
//{
//    //console.writeline($"{o1} y {o2} son distintos y {o1} es menor a {o2}");
//}
//else
//{
//    //console.writeline($"{o1} y {o2} son distintos y {o1} es mayor a {o2}");
//}

////console.writeline("--------------------------------------------------------------------");

//// 4)
//short n4 = 5;
//string texttoshow = string.empty;

//switch (n4)
//{
//    case 1:
//    case 2:
//    case 3:
//        texttoshow = "intervalo del 1 al 3";
//        break;
//    case 4:
//    case 5:
//    case 6:
//        texttoshow = "intervalo del 4 al 6";
//        break;
//    case 7:
//    case 8:
//    case 9:
//    case 10:
//        texttoshow = "intervalo del 7 al 10";
//        break;
//    default:
//        texttoshow = "el número no está en el rango de 1 a 10.";
//        break;
//}
////console.writeline(texttoshow);
////console.writeline("--------------------------------------------------------------------");

//// 5)
//int suma = 0;
//int i = 0;

//do
//{
//    suma += i;
//    i++;
//} while (i <= 10);
////console.writeline($"el resultado de la sumatoria de los primeros 10 es: {suma}" );

////console.writeline("--------------------------------------------------------------------");

//// 6) 
//int[] myarray = [1, 6, 8, 3, 5, 8, 3, 5, 9, 4];
//int producto = 1;

//foreach(int numero in myarray)
//{
//    producto *= numero;
//}

////console.writeline($"el resultsado de multiplicar los numero de mi array es: {producto}");


////clase 5

//int sumar(int num1, int num2)
//{
//    return num1+num2;
//}

//console.writeline(sumar(10,15));

//void escribirtexto(string texto)
//{
//    console.writeline(texto);
//}

//escribirtexto("hola a todos");


//int? dividir (int num1, int num2)
//{
//    if (num2 == 0)
//    {
//        console.writeline("no se puede dividir por 0");
//        return null;
//    }else
//    {
//        return (num1 / num2);
//    }

//}

//int? resultado = dividir(10, 5);

//escribirtexto($"la division de 10 y 5 es: {resultado}");
//escribirtexto($"la division de 10 y 0 es: {dividir(10, 0)}");

//string concatenar (string tex1, string tex2)
//{
//    return tex1 + tex2;
//}

////console.writeline(concatenar("juan", "schiavoni"));

//string devolvertiempo(bool soleado)
//{
//    if (soleado)
//    {
//        return "es un dia soleado";
//    }else
//    {
//        return "es un dia nublado";
//    }
//}

//string devolvernombrecompleto(string nombre, string apellido = "")
//{
//    return ($"{nombre} {apellido}");
//}

//console.writeline(devolvernombrecompleto("juan", "schiavoni"));
//console.writeline(devolvernombrecompleto("juan"));

//Console.WriteLine("Ejemplo con AUTOS");

//Auto vwUP = new Auto();
//Console.WriteLine($"Cantidad de ruedas: {vwUP.CantidadDeRuedas}");
//vwUP.Año = 2018;
//vwUP.Color = "Negro";
//vwUP.VelocidadMaxima = 140;
//vwUP.CantidadPuerta = 5;
//vwUP.Encender();
//vwUP.Acelerar(20);
//vwUP.Acelerar(20); 
//vwUP.Acelerar(20); 
//vwUP.Acelerar(20);
//vwUP.Acelerar(20);
//vwUP.Acelerar(); 
//vwUP.Acelerar();
//vwUP.Acelerar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Frenar();
//vwUP.Apagar();

//Auto cronos = new Auto();
//Console.WriteLine($"Cantidad de ruedas: {cronos.CantidadDeRuedas}");
//cronos.Año = 2023;
//cronos.Color = "Gris";
//cronos.VelocidadMaxima = 160;
//cronos.CantidadPuerta = 4;
//cronos.Encender();
//cronos.Acelerar();
//cronos.Apagar();


//CLASE 6 

//Auto golf = new Auto();
//Console.WriteLine($"Cantidad de ruedas: {golf.CantidadDeRuedas}");
//golf.Año = 2024;
//golf.Color = "Negro";
//golf.VelocidadMaxima = 260;
//golf.CantidadPuerta = 5;
//golf.Encender();
//golf.Acelerar(80);
//golf.Acelerar();
//golf.Frenar();
//golf.Apagar();

//Console.WriteLine("Ejemplo con MOTOS");

//Moto vespa = new Moto();
//Console.WriteLine($"Cantidad de ruedas: {vespa.CantidadDeRuedas}");
//vespa.Color = "Amarillla";
//vespa.Año = 2010;
//vespa.VelocidadMaxima = 80;
//vespa.Encender();
//vespa.Acelerar();
//vespa.Frenar();
//vespa.Apagar();

//TAREA Metodos y POO

//int Sumador(int n1, int n2)
//{
//    int suma = 0;
//    return suma = n1 + n2;
//}

////Console.WriteLine(Sumador(5, 2));

//string ConcatString (string s1, string s2) 
//{  
//    return ($"{s1} {s2}"); 
//}

////Console.WriteLine(ConcatString("Hola", "mundo!"));

//double Descuento(int cantidad, int precio)
//{
//    int total = 0;
//    total = cantidad * precio;
//    if (total > 1000)
//    {
//        return total - (total * 10) / 100;
//    }
//    else
//    {
//        return cantidad * precio;
//    }
//}

////Console.WriteLine(Descuento(5, 200));

//void Asteriscos(int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



//Libro libro  = new Libro();
//libro.titulo = "Martín Fierro";
//libro.autor = "José Hernández";
//libro.cantidad = 10;
//libro.cantidadPrestados = 3;

//Libro libro2 = new Libro();
//libro2.titulo = "Don Quijote de la Mancha";
//libro2.autor = "Miguel de Cervantes";
//libro2.cantidad = 5;
//libro2.cantidadPrestados = 2;

//libro.MostrarLibros();
//Asteriscos(70);
//libro2.MostrarLibros();

//Asteriscos(70);

//libro.Prestar();
//libro.Prestar();

//libro.Devolver();
//libro.Devolver();
//libro.Devolver();


//CLASE 7

//Profesor profesor1 = new(28987654, "Juan", "Perez", new DateOnly(1980, 5, 1), 25);
//Curso curso1 = new("Aprendiendo .NET", 3, profesor1);

//Curso curso2 = new("Aprendiendo a Cocinar", 10, profesor1);

//for (int i = 0; i < curso1.CantMaxAlumnos; i++)
//{
//    Console.WriteLine($"Ingrese el alumno {i + 1}");
//    Console.Write("DNI: ");
//    long dni = long.Parse(Console.ReadLine());
//    Console.Write("Nombre: ");
//    string nombre = Console.ReadLine();
//    Console.Write("Apellido: ");
//    string apellido = Console.ReadLine();

//    Console.Write("Fecha de nacimiento(dd/mm/aaaa): ");
//    string fecha = Console.ReadLine();
//    DateOnly fechaNac = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));

//    Console.Write("Trabaja? (SI/NO): ");
//    bool trabaja = Console.ReadLine() == "SI";

//    //Forma larga de hacer lo mismo q abajo
//    Alumno alumno = new Alumno (dni, nombre, apellido, fechaNac, trabaja);
//    //curso1.Alumnos[0] = alumno;

//    //curso1.Alumnos[i] = new Alumno(dni, nombre, apellido, fechaNac, trabaja);
//    curso1.Alumnos.Add(alumno);

//    Console.WriteLine("-------------------------------------------------------------------");
//}

////Alumno alumno1 = new(34555871, "Cristian", "Rodriguez", new DateOnly(2001, 10, 12), false);
////curso1.Alumnos[0] = alumno1;

//Console.WriteLine($"Los alumnos del curso {curso1.Nombre} son: ");

////for (int i = 0; i < curso1.CantMaxAlumnos; i++ )
////{
////    Console.WriteLine($"Alumno {i+1}: {curso1.Alumnos[i].Nombre} {curso1.Alumnos[i].Apellido}");
////} ;

//foreach (var alumno in curso1.Alumnos)
//{
//    //Console.WriteLine($"Alumno: {alumno.Nombre} {alumno.Apellido}");
//    Console.WriteLine(alumno.DevolverNombreCompleto());
//}


////CLASE 8

//string nombreABuscar = "Juan";
//Alumno? alumnoEncontrado = curso1.Alumnos.Find(a => a.Nombre == nombreABuscar);

//if( alumnoEncontrado == null)
//{
//    Console.WriteLine("No se encontro a Martin");
//}
//else
//{
//    Console.WriteLine(alumnoEncontrado.DNI);
//}

//List<Alumno> alumnosEncontrados = curso1.Alumnos.FindAll(a => a.Nombre == nombreABuscar);

//Profesor profesor = new(29847312, "Martin", "Comparetto", new DateOnly(1981, 11, 23), 20);

//profesor.NombreCompleto = "Juan Perez";

//var nombreCompleto = profesor.NombreCompleto;

//Console.WriteLine(profesor.NombreCompleto);

//Alumno alumno = new Alumno(34555764, "Pedro", "Martinez", new DateOnly(1999, 01, 05), false);


//Console.WriteLine(profesor.DevolverNombreCompleto());
//Console.WriteLine(alumno.DevolverNombreCompleto());

//Console.WriteLine(profesor.Saludo());
//Console.WriteLine(alumno.Saludo());

//Persona persona = new Persona(45666732, "Marcos", "Landa", new DateOnly(1981, 11, 23));