using System;
using System.Text.RegularExpressions;//integra las expresiones regulares

namespace ExpresionesRegularesI
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi dominio es: https://www.google.com/";
            //se llama secuencia de escape si no se agrega la @
            //la arroba permite ingresar caracteres de escape
            //permite encontrar uno o ninguna coincidencia para eso sirve el ? para prescindir del www. o de la s del http
            string patron = "https?://(www.)?google.com/";
            //crea una instacion de la expresion regular patron
            //mete todas las coincidencias en una coleccion, luego manualmente se recorre
            Regex miRegex = new Regex(patron);
            //busca coincidencias en esta frase utilizando la expresion regular de miRegex
            //y todas las coincidencias la mete en la matchcoleccion elmatch
            MatchCollection elmatch = miRegex.Matches(frase);

            if (elmatch.Count > 0) Console.WriteLine("Se ha encontrado web");
            else Console.WriteLine("No se ha encontrado web");
        }
    }
}
