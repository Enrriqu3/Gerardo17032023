// See https://aka.ms/new-console-template for more information
using ActividadAsincrona_Semana_8.Models;

Console.WriteLine();

Console.WriteLine("           ******************************************************************       ");
Console.WriteLine("             BIENVENIDO HA REGISTRAR PRODUCTOS EN LA BASE DE DATOS <ALMACEN>        ");
Console.WriteLine("           ******************************************************************       ");

AlmacenContext db = new AlmacenContext();
Producto producto = new Producto();

Console.WriteLine();

Console.Write("- Ingrese un Nombre de producto ---> ");
producto.Nombre = Console.ReadLine();
Console.Write("- Ingrese la descripción del producto ---> ");
producto.Descripcion = Console.ReadLine();
Console.Write("- Ingrese el presio de el producto ---> ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("- Ingrese la cantidad de productos ---> ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(producto);
db.SaveChanges();

Console.WriteLine();

Console.WriteLine("             -----------------------------------------                  ");
Console.WriteLine("             PRODUCTOS REGISTRADOS EN LA BASE DE DATOS                  ");
Console.WriteLine("             -----------------------------------------                  ");

Console.WriteLine();

var LisProducto = db.Productos.ToList();
foreach (var usu in LisProducto)
{
    Console.WriteLine($"Id: {usu.Id}, NOMBRE: {usu.Nombre}, DESCRIPCION: {usu.Descripcion}, PRECIO: {usu.Precio}, STOCK: {usu.Stock}");
}

Console.WriteLine();

Console.Write("*FIN DE REGISTROS*");

Console.WriteLine();

