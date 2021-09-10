using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPeople
{
    class Recursivity
    {
        static readonly String[,] ArrayPersonas = { {"Juan", "Juan", "Fernando", "Maria" }, {"Pedro", "Fernando", "Maria", "Clara"} };
        static List<String> people = new List<string>();
        public static List<String> Saludar(String saludado, String saludador)
        {
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
