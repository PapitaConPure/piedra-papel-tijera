using System;

namespace ppt
{
    class Jugador {
        private static Random random = new Random();

        public Jugador(string nombre)
        {
            this.Puntos = 0;
            this.Nombre = nombre;
            this.CntPiedra = this.CntPapel = this.CntTijera = 0;
        }

        public int Puntos { get; set; }

        public string Nombre { get; private set; }

        public int CntPiedra { get; private set; }

        public int CntPapel { get; private set; }

        public int CntTijera { get; private set; }

        public void Jugar(int jugada) {
            this.ContarJugada(jugada);
        }

        public int Jugar()
        {
            int jugada = random.Next(3);

            this.ContarJugada(jugada);

            return jugada;
        }

        private void ContarJugada(int jugada)
        {
            switch (jugada)
            {
                case 0: this.CntPiedra++; break;
                case 1: this.CntPapel++; break;
                case 2: this.CntTijera++; break;
            }
        }
    }
}