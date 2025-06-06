using System;
using System.Collections.Generic;

class Online : Ubicacion
{
    private string enlace;
    public Online(string en, int id)
    {
        /// <summary>
        /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
        /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
        /// </summary>
        tipo = Tipo.online;
        this.id = id;
        enlace = en;

    }
}