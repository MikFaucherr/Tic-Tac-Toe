using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class Tableau
    {
        public char[] tableau;
        

        public Tableau()
        {
            this.tableau = new char[9] {
            ' ', ' ' , ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            };
            
        }

        public bool gagnerTicTacToe(char symbole)
        {
            bool gagne = true;


            if (this.tableau[0] == symbole && this.tableau[1] == symbole && this.tableau[2] == symbole)
            {
                gagne = false;
            }
            if (this.tableau[3] == symbole && this.tableau[4] == symbole && this.tableau[5] == symbole)
            {
                gagne = false;
            }
        
            if (this.tableau[6] == symbole && this.tableau[7] == symbole && this.tableau[8] == symbole)
            {
                gagne = false;
        
        }

            if (this.tableau[0] == symbole && this.tableau[3] == symbole && this.tableau[6] == symbole)
            {
                gagne = false;
        }
        
            if (this.tableau[1] == symbole && this.tableau[4] == symbole && this.tableau[7] == symbole)
            {
               gagne = false;
        
        }
            if (this.tableau[2] == symbole && this.tableau[5] == symbole && this.tableau[8] == symbole)
            {
                gagne = false;
        
        }
            if (this.tableau[0] == symbole && this.tableau[4] == symbole && this.tableau[8] == symbole)
            {
                gagne = false;
        
        }
            if (this.tableau[2] == symbole && this.tableau[4] == symbole && this.tableau[6] == symbole)
            {
                gagne = false;
        
        }

            return gagne;
        }

        public bool placerSymbole(int position ,  char symbole)
        {
            bool placer = true;

            if (this.tableau[position] != 'X' || this.tableau[position] != 'O')
            {
            
                placer = false;  
            }
            return placer;

        }

        public bool isFini(int nbtour)
        {
            bool isFini = true;

            if (nbtour >= 9)
            {
                isFini = false;
            }
            return isFini;
        }

        public void afficherJeu()
        {
            Console.WriteLine(this.tableau[0] + " " + this.tableau[1] + " " + this.tableau[2] + "\n" + this.tableau[3] + " " + this.tableau[4] + " " + this.tableau[5] + "\n" + this.tableau[6] + " " + this.tableau[7] + " " + this.tableau[8] );
        }

    }
    
}
