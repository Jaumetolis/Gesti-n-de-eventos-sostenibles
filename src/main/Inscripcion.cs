using System;
using System.Collections.Generic;

class Inscripcion
{
    private Usuario usuario;
    private Evento evento;
    private DateTime fechaInscripcion;
    public Inscripcion(Usuario usuario, Evento evento) 
    {
        /// <summary>
        /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
        /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
        /// </summary>
        this.usuario = usuario;
        this.evento = evento;
        fechaInscripcion = DateTime.Now;
    }
    public Usuario Usuario { get { return usuario; }}
    public Evento Evento { get { return evento; }}
}
