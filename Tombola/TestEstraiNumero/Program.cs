using System;
using System.Threading;
using Tombola;

namespace TestEstraiNumero
{
    class Program
    {


        static void Main ( string[] args )
        {
            byte scelta;
            GameUtil gameUtil = new GameUtil();
            for ( int i = 0 ; i < 90 ; i++ )
            {
                scelta = gameUtil.GetNumber();
                Console.WriteLine( "Ciclo numero: {0} numero estratto {1}" , i + 1 , scelta );
                Thread.Sleep( 300 );
            }

            Console.ReadLine();


        }


    }

}
