using Tombola;

namespace Cartellina
{
    class CartellinaController
    {
        GameUtil gameUtil = new GameUtil();

        private byte[] numeriCartellina;


        public CartellinaController ()
        {
            numeriCartellina = new byte[ 15 ];
            numeriCartellina = gameUtil.EstraiNNumeri( 15 );
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
