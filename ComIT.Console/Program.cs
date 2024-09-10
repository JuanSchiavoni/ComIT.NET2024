string nombre = "Juanchi";
int edad = 26;
double precio = 15.3;
bool estaNublado = true;
char letra = 'S';
DateTime dateTime = DateTime.Now;
DateOnly fechaSola;
TimeOnly horaSola;

const string cintestaSaludo = "Buen día";

string saludo;

if(estaNublado)
{
    string apellido = "Schiavoni";
    if (letra == 'S')
    {
        apellido = "Ramirez";
    }
    //saludo = "Hola " + nombre + " " + apellido + "!. Hoy no es un buen dia!";
    saludo = $"Hola {nombre.ToUpper()} {apellido}!. Hoy no es un buen dia!";
}
else
{
    string apodo = "Pepe";
    //saludo = "Hola " + nombre + " mi amigo " + apodo + "!. Que lindo dia es hoy!";
    saludo = $"Hola {nombre} mi amigo {apodo}!. Que lindo dia es hoy!";
}

Console.WriteLine(saludo);

Console.WriteLine($"Hola {nombre}! hoy es {(estaNublado? "un feo dia" : "un hermoso dia")}");


int num1 = 10;
int num2 = 20;

int suma = num1 + num2;
Console.WriteLine($"La suma de {num1} + {num2} es igual a {suma:F3}");

int producto = num1 * num2;
Console.WriteLine(producto);

num1++;
Console.WriteLine(num1);

num2--;
Console.WriteLine(num2);

num1 += 100;
Console.WriteLine(num1);

string operador = "exponencial";
int resultado = 0;

if (operador == "suma") 
{
    resultado = num1 + num2;
}else if (operador == "resta")
{
    resultado = num1 - num2;
}else if(operador == "multi")
{
    resultado = num1 * num2;
}else if(operador == "division") {
    resultado = num1 / num2;
}
else
{
    resultado = -1;
}

Console.WriteLine($"El resultado de la {operador} es igual a {resultado}");

//Tarea!!!
//1
int n = 10;
n += 5;
Console.WriteLine(n);
//2
string f1 = "Hello";
string f2 = "word!!";
Console.WriteLine($"{f1} {f2}");
