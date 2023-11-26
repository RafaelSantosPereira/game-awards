using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_M9_classes
{
    internal class info
    {
        private string bestgame;
        private string nota;
        private string nome;
        private string consola;
        private int idade;

        public string Bestgame
        {
            get { return bestgame; }
            set { bestgame = value; }
        }
        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Consola
        {
            get { return consola; }
            set { consola = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string calcular(int index = 0)
        {
            if (index == 0) bestgame = "Elden Ring";
            else if (index == 1) bestgame = "God of War";
            else if (index == 2) bestgame = "Red Dead Redemption 2";
            else if (index == 3) bestgame = "Horizon Forbiden West";
            else if (index == 4) bestgame = "Call of Duty MW2";
            else if (index == 5) bestgame = "Forza Horizon 5";
            else if (index == 6) bestgame = "Halo Infinite";
            else if (index == 7) bestgame = "Super Mario Odissey";
            else if (index == 8) bestgame = "Zelda Breath of the Wild";
            else if (index == 9) bestgame = "Mario Kart 8 Deluxe";
            else if (index == 10) bestgame = "CSGO";
            return bestgame;
        }
        public string calcular2(int index2 = 0)
        {
            if (index2 == 0) consola = "Xbox Series X";
            else if (index2 == 1) consola = "ps5";
            else if (index2 == 2) consola = "Nintendo Switch";

            return consola;
        }
    }
}
