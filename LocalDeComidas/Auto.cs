using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDeComidas {
  internal class Auto : IVehiculo {
    private int _tiempoXCuadra;
    public int tiempoXCuadra => _tiempoXCuadra;
    private int _capacidadTanque;
    public int capacidadTanque => _capacidadTanque;

    public Auto() {
      _tiempoXCuadra = 400;
      _capacidadTanque = 10000;
    }
  }
}
