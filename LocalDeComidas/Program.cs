using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LocalDeComidas {
  internal class Program {
    public static AdministrarDelivery AdminDelivery = new AdministrarDelivery();
    static void Main(string[] args) {
      AgregarDeliverys();
    }

    public static void AgregarDeliverys() {
      string respuesta = "";
      while (respuesta.ToLower() != "no") {
        Console.Clear();
        Console.WriteLine("NUEVO DELIVERY");
        try {
          AdminDelivery.IngresarDatosDelivery();
        } catch (Exception ex) {
          Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Desea ingresar otro Delivery?");
        respuesta = Console.ReadLine();
      }
    }


  }
}
