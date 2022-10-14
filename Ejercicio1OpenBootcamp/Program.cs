//clase Coche
public class Coche
{
    //Propiedades
    public int numPuertas { get; set; }
    //Metodos
    public int incrementarPuertas(int puertas) //Al número de puertas (3) se le agrega +1
    {
        return ++puertas;
    }
}


class Ejercicio1
{
    static void Main()
    {
        //=============================== PARTE UNO ============================================

        static int numSuma(int numUno, int numDos, int numTres)
        {
            return numDos + numUno + numTres;
        }

        int suma;
        suma = numSuma(1, 2, 3);
        Console.WriteLine(suma);

        //=============================== PARTE DOS ============================================

        Coche miCoche = new();

        miCoche.numPuertas = miCoche.incrementarPuertas(3); // 3 + 1 = 4
        Console.WriteLine(miCoche.numPuertas);

    }
}
/*
    Output:
    suma : 6
    numPuertas : 4
*/