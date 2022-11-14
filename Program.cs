namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tableau jeu = new Tableau();
            bool xGagne = true;
            bool oGagne = true;
            char[] tableauposition = new char[9] {
            '0','1','2',
            '3','4','5',
            '6','7','8',
            };
            int position = 0;
            string positionn = "";
            char symbole = ' ';
            bool jeufinis = true;
            int nbtour = 0;

            while (xGagne && oGagne && jeufinis)
            {
                //TOUR DES X
                symbole = 'X';
                bool positionvalide = true;
                while (positionvalide)
                {
                    Console.WriteLine(tableauposition[0] + " " + tableauposition[1] + " " + tableauposition[2] + "\n" + tableauposition[3] + " " + tableauposition[4] + " " + tableauposition[5] + "\n" + tableauposition[6] + " " + tableauposition[7] + " " + tableauposition[8]);
                    Console.WriteLine(" C'est au tour du Joueur 1 ou voulez vous mettre votre symbole? ");
                    positionn = Console.ReadLine();
                    int.TryParse(positionn, out position);
                    if (position <= 9)
                    {
                        positionvalide = jeu.placerSymbole(position, symbole);


                    }
                }

                    jeu.tableau[position] = symbole;
                    nbtour++;
                   
                    xGagne = jeu.gagnerTicTacToe(symbole);

                    jeufinis = jeu.isFini(nbtour);

                    jeu.afficherJeu();

                //TOUR DES X
                symbole = 'O';
                positionvalide = true;
                while (positionvalide)
                {
                    //Console.WriteLine(tableauposition[0] + " " + tableauposition[1] + " " + tableauposition[2] + "\n" + tableauposition[3] + " " + tableauposition[4] + " " + tableauposition[5] + "\n" + tableauposition[6] + " " + tableauposition[7] + " " + tableauposition[8]);
                    Console.WriteLine(" C'est au tour du Joueur 2 ou voulez vous mettre votre symbole? ");
                    positionn = Console.ReadLine();
                    int.TryParse(positionn, out position);
                    if (position <= 9)
                    {
                        positionvalide = jeu.placerSymbole(position, symbole);


                    }
                }

                jeu.tableau[position] = symbole;
                nbtour++;

                xGagne = jeu.gagnerTicTacToe(symbole);

                jeufinis = jeu.isFini(nbtour);

                jeu.afficherJeu();


            }
        }
    }
}