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

using Microsoft.VisualBasic;

Console.WriteLine("WHILE");
int n = 6;
while (n <= 5)
{
    Console.WriteLine(n);
    n++ ;
}

Console.WriteLine("DO WHILE");
int n1 = 6;
do
{
    Console.WriteLine(n1);
    n1++;
}while (n1 <= 5);


Console.WriteLine("ARRAY");
int[] nArray = new int[5];

nArray[0] = 5;
nArray[1] = 6;
//nArray[2] = 7;
nArray[3] = 8;
nArray[4] = 9;

Console.WriteLine(nArray[0]);
Console.WriteLine(nArray[1]);
Console.WriteLine(nArray[2]);
Console.WriteLine(nArray[3]);
Console.WriteLine(nArray[4]);

string[] texto = new string[5] {"Uno", "Dos", "Tres", "Cuatro", "Cinco"};
string[] textoSimple = ["Uno", "Dos", "Cuatro", "Cinco" ];

Array.Resize(ref textoSimple, 10);


Console.WriteLine("FOR");
for(int i = 0; i < texto.Length; i++)
{
    Console.WriteLine($"Posición {i}: {texto[i]}");
}

for (int i = 0; i < nArray.Length; i++)
{
    Console.WriteLine($"Posición {i}: {nArray[i]}");
}

for (int i = 0; i < textoSimple.Length; i++)
{
    Console.WriteLine($"Posición {i}: {textoSimple[i]}");
}

//Cuendo le ponemos ? a una variable significa que ademas de cualquier valor se le puede asignar null
string?[] cadenaNull = new string?[5] {"Uno", "", null, "Cuatro", "Cinco"};


Console.WriteLine("FOREACH");
foreach (var item in texto)
{
    Console.WriteLine(item);
}

foreach (var item in cadenaNull)
{
    //if (item == null)
    //{
    //    Console.WriteLine("Sin valor");
    //}else
    //{
    //    Console.WriteLine(item);
    //}

    //Console.WriteLine(item == null ? "Sin valor" : item);
    Console.WriteLine(item ?? "Sin valor");
    // ?? sirve solo para los null, si es null imprime sin valor sino imprime item


}