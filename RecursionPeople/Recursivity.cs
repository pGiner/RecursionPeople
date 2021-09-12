using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPeople
{
    public class Recursivity
    {
        static readonly String[,] ArrayPersonas = { {"Juan", "Juan", "Fernando", "Maria", "Clara", "German", "Jose", "Pablo", "Guillermo", "edu" }, {"Pedro", "Fernando", "Maria", "Clara", "Pablo", "Pedro", "Fabian", "Guillermo", "Laura", "Raul"} };
        static List<String> people = new List<string>();

        public static List<String> Saludar(String saludado, String saludador)
        {
            //recorremos el array para comprobar que los nombres estan o no en la lista
            int contSaludado = 0;
            int contSaludador = 0;
            for (int x = 0; x < ArrayPersonas.GetLength(0); x += 1)
            {
                for (int y = 0; y < ArrayPersonas.GetLength(1); y += 1)
                {
                    if (saludado == ArrayPersonas[x, y])
                    {
                        contSaludado++;
                    }

                    if (saludador == ArrayPersonas[x, y])
                    {
                        contSaludador++;
                    }
                }
            }

            if(contSaludado == 0 || contSaludador == 0)
            {
                throw new Exception("Name not found in the list");
            }

            if (!people.Contains(saludado))
            {
                people.Add(saludado);
            }
            
            
            if(saludado == saludador)
            {
                if (!people.Contains(saludado)) 
                {
                    people.Add(saludado);
                }
               
                return people;
            }

            for (int x = 0; x < ArrayPersonas.GetLength(0); x += 1)
            {
                for (int y = 0; y < ArrayPersonas.GetLength(1); y += 1)
                {
                    //X=0 PRIMERA COLUMNA, X=1 SEGUNDA COLUMNA
                    //Predefino el valor x para asegurarme que el nombre se coge siempre de la columna deseada
                    if(saludado.Equals(ArrayPersonas[1, y]))
                    {
                        if (!people.Contains(ArrayPersonas[0, y]))
                        {
                            people.Add(ArrayPersonas[0, y]);
                        }
                        Saludar(ArrayPersonas[0, y], saludador);                        
                    }
                }
            }
            
            return people;
        }
    }
}
