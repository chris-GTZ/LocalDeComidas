using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDeComidas {
  internal class Moto : IVehiculo {
    private int _tiempoXCuadra;
    public int tiempoXCuadra => _tiempoXCuadra;
    private int _capacidadTanque;
    public int capacidadTanque => _capacidadTanque;

    public Moto() {
      _tiempoXCuadra = 200;
      _capacidadTanque = 5000;
    }
  }
}
