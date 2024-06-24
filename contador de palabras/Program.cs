using System;
using System.Collections.Generic;

namespace ContadorDePalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un texto o párrafo:");
            string inputText = Console.ReadLine();

            // Dividir el texto en palabras utilizando espacios en blanco como separadores
            string[] words = inputText.Split(' ');

            // Crear un diccionario para almacenar las palabras y sus frecuencias
            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            // Recorrer el array de palabras
            foreach (string word in words)
            {
                // Convertir la palabra a minúsculas para evitar duplicados (mayúsculas/minúsculas)
                string lowercaseWord = word.ToLower();

                // Si la palabra ya existe en el diccionario, incrementar su frecuencia
                if (wordFrequencies.ContainsKey(lowercaseWord))
                {
                    wordFrequencies[lowercaseWord]++;
                }
                else
                {
                    // Si no existe, agregarla con una frecuencia de 1
                    wordFrequencies.Add(lowercaseWord, 1);
                }
            }

            // Mostrar los resultados
            foreach (var pair in wordFrequencies)
            {
                Console.WriteLine($"Palabra: {pair.Key}, Frecuencia: {pair.Value}");
            }
        }
    }
}
