using Ejercicio_Aire_Acondicionado;
Console.WriteLine("========================================");
Console.WriteLine("   INGRESO DE DATOS - NUEVO EQUIPO");
Console.WriteLine("========================================");
Console.Write("Ingrese la Marca: ");
string marca = Console.ReadLine();
Console.Write("Ingrese las Frigorías: ");
int frigorias = int.Parse(Console.ReadLine());
Console.Write(" ¿Es un equipo Split? (S/N): ");
string respuestaSplit = Console.ReadLine();
bool split;
if (respuestaSplit.ToUpper() == "S")
{
    split = true;
}
else
{
    split = false;
}
Console.Write("Ingrese el País de fabricación: ");
string pais = Console.ReadLine();
Console.WriteLine("¿Es un equipo de Frío Solo? (S/N - 'N' significa Frío/Calor)");
string respuestaFrio = Console.ReadLine();
bool frioSolo;
if (respuestaFrio.ToUpper() == "S")
{
    frioSolo = true;
}
else
{
    frioSolo = false;
}
AireAcondicionado aire1 = new AireAcondicionado(marca, frigorias, split, pais, frioSolo);
Console.WriteLine("========================================");
Console.WriteLine("Procesando datos y creando objeto...");
Console.WriteLine("¡Equipo inicializado con éxito!");
Console.WriteLine("\n Presione cualquier tecla para abrir el Control Remoto...");
Console.ReadKey();

while (true)
{
Console.Clear();
Console.WriteLine($"MODELO EQUIPO: {aire1.Modelo}");
Console.WriteLine("========================================");
if (aire1.Encendido)
    {
        Console.WriteLine($" PANTALLA DIGITAL: [ ON ] | Temp: {aire1.Temperatura}°C");
    }
    else
    {
        Console.WriteLine(" PANTALLA DIGITAL: [ OFF ]");
    }
Console.WriteLine("======================================== ");
Console.WriteLine("[1] Presionar Botón POWER");
Console.WriteLine("[2] Presionar Botón TEMP +");
Console.WriteLine("[3] Presionar Botón TEMP -");
Console.WriteLine("[4] Presionar Botón TEMP MAX");
Console.WriteLine("[5] Presionar Botón TEMP MIN");
Console.WriteLine("[0] Salir del simulador");
Console.WriteLine("========================================");
Console.WriteLine("Seleccione una opción del control: _");
int op = int.Parse(Console.ReadLine());
switch (op){
        case 0:
            return;
        case 1:
            aire1.Power();
            break;

        case 2:
            aire1.Subir(1);
            break;

        case 3:
            aire1.Bajar(1);
            break;

        case 4:
            aire1.Subir();
            break;

        case 5:
            aire1.Bajar();
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
}
Console.WriteLine("\n Seleccione cualquier letra para continuar");
Console.ReadKey();
}