using System;

namespace tris_cs_console
{
    class Program{
        static void Main(string[] args){

            client c = new client();
            Console.WriteLine("gioco tris client:");
            bool acceptGame = false;
            string error;
            for (int i = 0; i < 3; i++){
                (acceptGame, error) = c.connect();
                if (acceptGame == true){
                    break;
                }
            }
            if (acceptGame == true){

            }else{
                Console.WriteLine("errore alla connessione al server, riprova piú tardi o idk, vedi tu ");
            }
        }
    }
}
