using System;
using System.Collections.Generic;

class Organizador
{
    private int id;
    private string nombre;
    private string correo;
    private string numero;
    private string contraseña;
    private List<Evento> eventosCreados;

    public Organizador(int id,string nombre, string correo, string numero, string contraseña)
    {
        /// <summary>
        /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
        /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
        /// </summary>
        this.id = id;
        this.nombre = nombre;
        this.correo = correo;
        this.numero = numero;
        this.contraseña = contraseña;
        eventosCreados = new List<Evento>();
    }

    public void CrearEvento(DateTime fecha, string nombre, int duracion, int aforoMaximo, Ubicacion lugar, Categoria categoria, int id)
    {
        Evento evento = new Evento(fecha, nombre, duracion, aforoMaximo, lugar, categoria, this, id);
    }
    public void ModificarEvento(Evento e,DateTime fecha, string nombre, int duracion, int aforoMaximo, Ubicacion lugar, Categoria categoria)
    {
        bool encontrado = false;
        foreach (Evento ev in eventosCreados)
        {
            if (ev == e) encontrado = true;
        }
        if (encontrado)
        {
            e.Fecha = fecha;
            e.Nombre = nombre;
            e.Duracion = duracion;
            e.Categoria = categoria;
            e.Lugar = lugar;
            e.AforoMaximo = aforoMaximo;
        }
    }
    public void CancelarEvento(Evento e) 
    {
        bool encontrado = false;
        foreach (Evento ev in eventosCreados)
        {
            if (ev == e) encontrado = true;
        }
        if (encontrado)
        {
            e.CancelarEvento();
        }
    }
}