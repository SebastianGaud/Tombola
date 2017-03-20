using System;
using Tombola;

namespace Cartellina
{
    public class CartellinaController
    {
        GameUtil gameUtil = new GameUtil();

        public byte[] NumeriCartellina { get; set; }

        public event Action OnCinquina;
        public event Action OnTombola;


        public CartellinaController ()
        {
            NumeriCartellina = new byte[ 15 ];
            NumeriCartellina = gameUtil.EstraiNNumeri( 15 );
        }

        public bool Cinquina ( byte[] riga1 , byte[] riga2 , byte[] riga3 )
        {
            if ( !ControllaRiga( riga1 ) )
            {
                return false;
                if ( !ControllaRiga( riga2 ) )
                {
                    return false;
                    if ( !ControllaRiga( riga3 ) )
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }
        }

        private bool ControllaRiga ( byte[] riga )
        {
            for ( int i = 0 ; i < riga.Length ; i++ )
            {
                if ( riga[ 0 ] == riga[ i ] )
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}
