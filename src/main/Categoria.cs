using System;
using System.Collections.Generic;eric;

class Categoria
{
    private string nombre;
    private string descripcion;
    public Categoria(string nombre, string descripcion)
    {
        /// <summary>
        /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
        /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
        /// </summary>
        this.nombre = nombre;
        this.descripcion = descripcion;
    }
    public List<Evento> FiltrarPorCategorias(List<Evento> eventos)
    {
        List <Evento> lista = new List <Evento> ();
        foreach (Evento e in eventos)
        {
            if (e.Categoria.nombre == nombre) lista.Add (e);
        }
        return lista;
    }
}