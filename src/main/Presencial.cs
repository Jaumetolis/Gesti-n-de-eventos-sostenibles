using System;
using System.Collections.Generic;

class Presencial : Ubicacion
 {
     private string direccion;
     public Presencial(string dir, int id)
     {
         /// <summary>
         /// Ha pesar de que este código no se va a conectar con una base de datos los atributos de los constructores
         /// seran siempre pasados por parametro, para simular el caso en el que tuviera un bd que me de los valores
         /// </summary>
         tipo = Tipo.presencial;
         this.id = id;
         direccion = dir;

     }
 }