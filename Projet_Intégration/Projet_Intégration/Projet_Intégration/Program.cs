using System;


namespace Projet_Intégration
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Main(string[] args)
        {
            using (Jeu jeu = new Jeu())
            {
                jeu.Run();
            }
        }
    }
#endif
}

