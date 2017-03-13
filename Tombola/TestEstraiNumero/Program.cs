using System;
using System.Collections.Generic;

namespace TestEstraiNumero
{
    class Program
    {
        private static LinkedList<byte> numeriCasuali = GeneraArray();

        static void Main ( string[] args )
        {
            numeriCasuali = GeneraArray();

        }

        private static LinkedList<byte> GeneraArray ()
        {
            LinkedList<byte> numeri = new LinkedList<byte>();
            for ( int i = 0 ; i < 90 ; i++ )
            {
                numeri.AddLast( Convert.ToByte( i + 1 ) );
            }

            return numeri;
        }

        private static byte EstraiNumeri ( byte[] casuali )
        {
            Random myRand = new Random();

            int scelta = myRand.Next( 0 , numeriCasuali.Count );
            numeriCasuali.Remove( ( byte ) scelta );
            return casuali[ scelta - 1 ];
        }

    }

}
