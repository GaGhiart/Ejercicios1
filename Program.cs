Console.WriteLine("Escribe tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu edad");
string edad = Console.ReadLine();
Console.WriteLine("Tu nombre es " + nombre + "y tu edad es " + edad);


string hora = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine("Hora actual " + hora);