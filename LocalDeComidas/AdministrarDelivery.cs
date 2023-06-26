using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDeComidas {
  internal class AdministrarDelivery {
    List<Delivery> deliveryList = new List<Delivery>();

    public void IngresarDatosDelivery() {
      string nombre;
      string apellido;
      string dni;
      byte vehiculo;

      Console.WriteLine("DATOS DEL DELIVERY");
      Console.Write("-Ingresar el nombre: ");
      nombre = Console.ReadLine();
      Console.Write("-Ingresar el apellido: ");
      apellido = Console.ReadLine();
      Console.Write("-Ingresar el dni: ");
      dni = Console.ReadLine();
      Console.Write("-Tipo de vehiculo\n\t1-Auto\n\t2-Moto\nIngrese el tipo de vehiculo: ");
      vehiculo = Convert.ToByte(Console.ReadLine());
      try {
        CrearDelivery(nombre, apellido, dni, vehiculo);
      } catch (Exception) {
        throw;
      }
    }

    private void CrearDelivery(string nombre, string apellido, string dni, byte vehiculo) {
      if (!string.IsNullOrWhiteSpace(nombre)
        && !string.IsNullOrWhiteSpace(apellido)
        && !string.IsNullOrWhiteSpace(dni)
        && (vehiculo == 1 || vehiculo == 2)) {
        if (vehiculo == 1) deliveryList.Add(new Delivery(nombre, apellido, dni, new Auto()));
        if (vehiculo == 2) deliveryList.Add(new Delivery(nombre, apellido, dni, new Moto()));
      } else throw new Exception("Delivery no creado: Datos no válidos");
    }
  }
}
