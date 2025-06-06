using System;
using System.Collections.Generic;

class Evento
    {
        enum Estado 
        {
            activo,
            cancelado 
        }
        private int id;
        private string nombre;
        private string descripcion
        private int duracion;
        private DateTime fecha;
        private int aforoMaximo;
        private Estado estado;
        private Organizador organizador;
        private Categoria categoria;
        private Ubicacion lugar;
        private List<Inscripcion> lista;

        public Evento(DateTime fecha, string nombre, int duracion, string descripcion, int aforoMaximo, Ubicacion lugar, Categoria categoria, Organizador organizador, int id)
        {
            /// <summary>
            /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
            /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
            /// </summary>
            this.id = id;
            this.fecha = fecha;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.aforoMaximo = aforoMaximo;
            this.lugar = lugar;
            this.estado = Estado.activo ;
            this.organizador = organizador;
            this.categoria = categoria;
            lista = new List<Inscripcion>();
        }

        public DateTime Fecha { set { fecha = value; } }
        public string Nombre { set { nombre = value; } }
        public int Duracion { set { duracion = value; } }
        public int AforoMaximo { set { aforoMaximo = value; } }
        public Categoria Categoria { set { categoria = value; } get { return categoria ; } }
        public Ubicacion Lugar { set { lugar = value; } }

        /// <summary>
        /// No se si es al mejor forma de hacerlo, ya que he hecho una agregación en vez de una composición,
        /// por lo que si eliminaramos el evento o el usuario, la inscripción seguiria existiendo, pero si no,
        /// el problema que tenia cuando usaba una composición es que duplicaba objetos.
        /// </summary>

        //Codigo antiguo:
        //public void RegistrarParticipante(Usuario u)
        //{
        //    lista.Add(new Inscripcion(u, this));
        //}


        public void RegistrarParticipante(Inscripcion i)
        {
            lista.Add(i);
        }
        public void EliminarParticipante(Inscripcion i)
        {
            lista.Remove(i);
        }
        public void CancelarEvento()
        {
            estado = Estado.cancelado; 
        }
    }