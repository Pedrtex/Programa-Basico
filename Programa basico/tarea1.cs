Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine(); 

Console.Write("Introduce tu apellido: ");
string apellido = Console.ReadLine(); 

Console.Write("Introduce tu edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Introduce tu altura: ");
float altura = float.Parse(Console.ReadLine());

Console.WriteLine($"Saludos " + nombre + " " + apellido + ", tus " + edad + " años de edad y tu altura de " + altura + " pies, se agregaron correctamente a la lista de solicitudes.");