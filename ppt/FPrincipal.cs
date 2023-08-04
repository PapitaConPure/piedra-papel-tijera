using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt
{
    public partial class FPrincipal : Form
    {
        Jugador jugador1;
        Jugador jugador2;

        FPartida fPartida;
        FSimulacion fSimulacion;

        public FPrincipal() {
            InitializeComponent();
        }

        private void btnJugadorCPU_Click(object sender, EventArgs e)
        {
            fPartida = new FPartida();

            if(tbNombre.Text.Length == 0)
                tbNombre.Text = "Jugador";

            jugador1 = new Jugador(tbNombre.Text);
            jugador2 = new Jugador("CPU");

            tbNombre.Clear();

            fPartida.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            fPartida.btnReportaje.Click += new System.EventHandler(this.btnReportaje_Click);
            fPartida.ShowDialog();
            fPartida.btnJugar.Click -= new System.EventHandler(this.btnJugar_Click);
            fPartida.btnReportaje.Click -= new System.EventHandler(this.btnReportaje_Click);

            fPartida.Dispose();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            #region Jugada del humano
            int jugada;

            if (fPartida.rbPiedra.Checked)
                jugada = 0;
            else if (fPartida.rbPapel.Checked)
                jugada = 1;
            else
                jugada = 2;

            jugador1.Jugar(jugada);
            #endregion

            #region Jugada de la máquina
            int jugadaMaquina = jugador2.Jugar();
            fPartida.textBox1.Text = $"{jugador2.Nombre} jugó {MuestraJugada(jugadaMaquina)}";
            #endregion

            #region Comprobar ganador
            int resultado = CompararJugadas(jugada, jugadaMaquina);

            fPartida.lbReportaje.Items.Clear();
            if (resultado > 0)
            {
                fPartida.lbReportaje.Items.Add($"Ganó {jugador1.Nombre}");
                jugador1.Puntos++;
            }
            else if (resultado < 0)
            {
                fPartida.lbReportaje.Items.Add($"Ganó {jugador2.Nombre}");
                jugador2.Puntos++;
            }
            else
                fPartida.lbReportaje.Items.Add("Empate");
            #endregion
        }

        private void btnReportaje_Click(object sender, EventArgs e)
        {
            fPartida.lbReportaje.Items.Clear();
            EscribirReportaje(fPartida.lbReportaje);
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            fSimulacion = new FSimulacion();

            jugador1 = new Jugador("CPU 1");
            jugador2 = new Jugador("CPU 2");

            for(int i = 0; i < 100; i++)
                SimularJugada();

            fSimulacion.lbResultados.Items.Add("--------------------");
            EscribirReportaje(fSimulacion.lbResultados);
            fSimulacion.lbResultados.Items.Add("--------------------");

            string textoGanador;

            if(jugador1.Puntos > jugador2.Puntos)
                textoGanador = $"Ganador final: {jugador1.Nombre}";
            else if(jugador1.Puntos < jugador2.Puntos)
                textoGanador = $"Ganador final: {jugador2.Nombre}";
            else
                textoGanador = "¡Es un empate!";

            fSimulacion.lbResultados.Items.Add(textoGanador);

            fSimulacion.ShowDialog();

            fSimulacion.Dispose();
        }

        private void SimularJugada()
        {
            int jugada1 = jugador1.Jugar();
            int jugada2 = jugador2.Jugar();
            int resultado = CompararJugadas(jugada1, jugada2);
            string textoResultado;

            if(resultado > 0)
            {
                textoResultado = $"Ganó {jugador1.Nombre}";
                jugador1.Puntos++;
            }
            else if(resultado < 0)
            {
                textoResultado = $"Ganó {jugador2.Nombre}";
                jugador2.Puntos++;
            }
            else
                textoResultado = "Empate";

            fSimulacion.lbResultados.Items.Add($"{jugador1.Nombre}: {MuestraJugada(jugada1)} - {jugador2.Nombre}: {MuestraJugada(jugada2)}: {textoResultado}");
        }

        private object MuestraJugada(int jugada)
        {
            switch(jugada)
            {
                case 0: return "Piedra";
                case 1: return "Papel";
                case 2: return "Tijera";
                default: return "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int CompararJugadas(int jugada1, int jugada2)
        {
            if (jugada1 == jugada2)
                return 0;

            if (jugada1 == 0 && jugada2 == 2 || jugada1 == 2 && jugada2 == 0)
            {
                int temp = jugada1;
                jugada1 = jugada2;
                jugada2 = temp;
            }

            if (jugada1 < jugada2)
                return -1;

            return 1;

        }

        private void EscribirReportaje(ListBox lbReportaje)
        {
            lbReportaje.Items.Add($"{jugador1.Nombre}: {jugador1.Puntos}");
            lbReportaje.Items.Add($"  Piedras: {jugador1.CntPiedra}");
            lbReportaje.Items.Add($"  Papeles: {jugador1.CntPapel}");
            lbReportaje.Items.Add($"  Tijeras: {jugador1.CntTijera}");
            lbReportaje.Items.Add("");
            lbReportaje.Items.Add($"{jugador2.Nombre}: {jugador2.Puntos}");
            lbReportaje.Items.Add($"  Piedras: {jugador2.CntPiedra}");
            lbReportaje.Items.Add($"  Papeles: {jugador2.CntPapel}");
            lbReportaje.Items.Add($"  Tijeras: {jugador2.CntTijera}");
        }
    }
}
