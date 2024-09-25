using System;

namespace Prime.Services
{
    public class PrimeService
    {
        //Nombre premier est un nombre entiers, < ou = à 2(ex: -1, 0, 1)
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            //le boucle divisor = 2 s'arréte lorsque divisor dépasse la racine carré du nombre(ex: 4, 6, 9)
            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            //si pas diviseur il envoit true (ex : 2; 3, 5, 7)
            return true;
        }
    }
}