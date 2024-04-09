// See https://aka.ms/new-console-template for more information
string continuar = "Yes";
while (continuar == "Yes"){

  Cliente cliente = new Cliente();

  Console.WriteLine("\n");
  Console.WriteLine("Ingresa el nombre del cliente");
  cliente.Nombre = Console.ReadLine();

  Console.WriteLine("Ingresa el numero de cedula");
  cliente.NumeroCedula = Console.ReadLine();
  Console.WriteLine("\n");
  decimal SaldoTotal = 0;

  Console.WriteLine($"El nombre del cliente es: {cliente.Nombre}");
  Console.WriteLine($"El numero de cedula es: {cliente.NumeroCedula}");
  Console.WriteLine($"El numero de cuenta es: 100{cliente.NumeroCedula}");
  Console.WriteLine($"El saldo de la cuenta es de: {SaldoTotal}\n");

  Console.WriteLine("Desea seguir ingreasando usuarios? Yes | No");
  continuar = Console.ReadLine();
}
if(continuar == "No"){
  Console.WriteLine("Gracias los usuarios ya fueron guradados");
}
struct Cliente{
  public string Nombre;
  public string NumeroCedula;
}

