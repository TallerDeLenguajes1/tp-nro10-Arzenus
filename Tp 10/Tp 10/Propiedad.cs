using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    class Propiedad
    {
        private int id;
        private string tipoDePropiedad;
        private string tipoDeOperacion;
        private float tamanio;
        private int cantidadDeBanios;
        private int cantidadDeHabitaciones;
        private string domicilio;
        private double precio;
        private bool estado;
        private double valorDelInmueble;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string TipoDePropiedad
        {
            get
            {
                return tipoDePropiedad;
            }

            set
            {
                tipoDePropiedad = value;
            }
        }

        public string TipoDeOperacion
        {
            get
            {
                return tipoDeOperacion;
            }

            set
            {
                tipoDeOperacion = value;
            }
        }

        public float Tamanio
        {
            get
            {
                return tamanio;
            }

            set
            {
                tamanio = value;
            }
        }

        public int CantidadDeBanios
        {
            get
            {
                return cantidadDeBanios;
            }

            set
            {
                cantidadDeBanios = value;
            }
        }

        public int CantidadDeHabitaciones
        {
            get
            {
                return cantidadDeHabitaciones;
            }

            set
            {
                cantidadDeHabitaciones = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }

            set
            {
                domicilio = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
