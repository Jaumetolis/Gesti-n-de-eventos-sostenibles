using System;
using System.Collections.Generic;


class Usuario
{
    private int id;
    private string nombre;
    private string correo;
    private string contraseña;
    private string telefono;
    private List<Inscripcion> lista;

    public Usuario(int id,string nombre,string correo,string contraseña, string telefono)
    {
        /// <summary>
        /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
        /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
        /// </summary>
        this.id = id;
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.correo = correo;
        this.telefono = telefono;
        lista = new List<Inscripcion>();
    }
    public Usuario(int id, string nombre, string correo, string contraseña)
    {
        this.id = id;
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.correo = correo;
        lista = new List<Inscripcion>();
    }
    /// <summary>
    /// No se si es al mejor forma de hacerlo, ya que he hecho una agregación en vez de una composición,
    /// por lo que si eliminaramos el evento o el usuario, la inscripción seguiria existiendo, pero si no,
    /// el problema que tenia cuando usaba una composición es que duplicaba objetos.
    /// 
    /// De la forma en la que lo he hecho simplemente creo el objeto en Usuario y se lo agrego también a el evento
    /// </summary>

    //Codigo antiguo:

    //public void IncribirseEnEvento(Evento e)
    //{
    //    lista.Add(new Inscripcion(this, e));
    //    e.RegistrarParticipante(this);
    //}

    public void IncribirseEnEvento(Evento e) 
    {
        bool encontrado = false;
        foreach (Inscripcion i in lista)
        {
            if (i.Evento == e) encontrado = true;
        }
        if (!encontrado)
        {
            Inscripcion ins = new Inscripcion(this, e);
            lista.Add(ins);
            e.RegistrarParticipante(ins);
        }
    }
    public void DesincribirseEnEvento(Inscripcion i)
    {
        i.Evento.EliminarParticipante(i);
        lista.Remove(i);
    }
}
