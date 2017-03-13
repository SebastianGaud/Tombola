using System;
using System.Collections.Generic;

namespace Tombola
{
    public class GameUtil
    {

        private Random myRand = new Random();
        //private static LinkedList<byte> numeriCasuali = GeneraArray();
        public LinkedList<byte> numeriCasuali { get; private set; }


        public GameUtil ()
        {
            numeriCasuali = GeneraArray();
        }

        public byte GetNumber ()
        {
            return EstraiNumeri();
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

        private byte EstraiNumeri ()
        {
            Random myRand = new Random();

            int scelta = myRand.Next( 0 , numeriCasuali.Count );
            numeriCasuali.Remove( ( byte ) scelta );

            return ( byte ) ( scelta - 1 );
        }


        public byte[] EstraiNNumeri ( int n )
        {
            byte[] numeriEstratti = new byte[ n ];

            for ( int i = 0 ; i < numeriEstratti.Length ; i++ )
            {
                int scelta = myRand.Next( 0 , numeriCasuali.Count );
                numeriCasuali.Remove( ( byte ) scelta );
                numeriEstratti[ i ] = ( byte ) scelta;
            }

            return numeriEstratti;
        }

        public void ResetList ()
        {
            GeneraArray();
        }
    }
}
