using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Personas P1 = new Personas();
    P1.Nombre = "Oscar";
    P1.Edad = 40;

    Personas P2 = new Personas();
    P2.Nombre = "Francisco";
    P2.Edad = 2;

    ComparaPersonas comparaEdad = (persona1, persona2)=> persona1 == persona2;
    Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));
  }

  //delegado
  public delegate bool ComparaPersonas(int edad1, int edad2);

  class Personas{
    private string nombre;
    private int edad;
    public string Nombre{
      get=>nombre;
      set=>nombre = value;
      }
    public int Edad{
      get=>edad;
      set=>edad = value;
    }
  }


}