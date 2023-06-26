using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDeComidas {
  internal class Delivery {
    private string[] _estados= {"Libre", "Repartiendo", "Cargando nafta"};

    private string _nombre;
    public string nombre {
      get { return _nombre; }
    }

    private string _apellido;
    public string apellido {
      get { return _apellido; }
    }

    private string _dni;
    public string dni {
      get { return _dni; }
    }

    private int _estado;

    public string estado {
      get { return _estados[_estado]; }
    }

    public IVehiculo vehiculo;

    public Delivery(string nombre, string apellido, string dni, IVehiculo vehiculo) {
      this._nombre = nombre;
      this._apellido = apellido;
      this._dni = dni;
      _estado = 0;
      this.vehiculo = vehiculo;
    }
  }
}
