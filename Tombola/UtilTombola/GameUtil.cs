using System;
using System.Collections.Generic;
using System.Linq;

namespace Tombola
{
    public class GameUtil
    {

        private Random myRand = new Random();
        //private static LinkedList<byte> numeriCasuali = GeneraArray();
        public LinkedList<byte> numeriCasuali { get; private set; }
        private int count = 0;

        public event Action OnPartitaTerminata;


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
            for ( int i = 1 ; i <= 90 ; i++ )
            {
                numeri.AddLast( Convert.ToByte( i + 1 ) );
            }

            return numeri;
        }

        private byte EstraiNumeri ()
        {
            Random myRand = new Random();

            int scelta = myRand.Next( 0 , numeriCasuali.Count );

            count++;
            if ( count == 90 )
            {
                OnPartitaTerminata();
            }
            else
            {
                byte numeroInPosizione = numeriCasuali.ElementAt( scelta );
                numeriCasuali.Remove( ( byte ) numeroInPosizione );

                return ( byte ) ( numeroInPosizione - 1 );
            }

            return 0;
        }


        public byte[] EstraiNNumeri ( int n )
        {
            byte[] numeriEstratti = new byte[ n ];

            for ( int i = 0 ; i < numeriEstratti.Length ; i++ )
            {
                int scelta = myRand.Next( 0 , numeriCasuali.Count );
                byte numeroInPosizione = numeriCasuali.ElementAt( scelta );
                numeriCasuali.Remove( ( byte ) numeroInPosizione );
                numeriEstratti[ i ] = ( byte ) numeroInPosizione;
            }

            return numeriEstratti;
        }

        public void ResetList ()
        {
            GeneraArray();
        }
    }
}
