using System;
using System.Diagnostics;
using System.Windows.Forms;
using StopWatch.Properties;

namespace StopWatch
{
    public partial class FrmCrono : Form
    {
        readonly Stopwatch wtcA = new Stopwatch();
        DateTime dtmbeginB, dtmendB;
        TimeSpan ElapsedTimeAcumulado = TimeSpan.Zero;

        public FrmCrono()
        {
            InitializeComponent();
            this.Icon = Resources.kalarm_2;
        }

        private void FrmCrono_Load(object sender, EventArgs e)
        {
            btnCrono.Image = Resources.accessories_clock.ToBitmap();
            btnRestart.Enabled = false;
        }

        private void BtnCrono_Click(object sender, EventArgs e)
        {
            if ( wtcA.IsRunning)
            {
        //-----------------------------------------------------------------
                //  Stop timing
                wtcA.Stop();
                dtmendB = DateTime.Now;
        //-----------------------------------------------------------------

                //  Show results
                lblEndA.Text = wtcA.ElapsedMilliseconds.ToString("N0");
                lblEndB.Text = ((dtmendB - dtmbeginB) + ElapsedTimeAcumulado).TotalMilliseconds.ToString("N0");

                btnCrono.Text = "Idle";
                btnRestart.Enabled = false;
            }
            else
            {
                //  Clear components
                lblEndA.Text = "0"; lblEndB.Text = "0";
                //  Reset time counters
                ElapsedTimeAcumulado = TimeSpan.Zero;

                btnCrono.Text = "Running";
                btnRestart.Enabled = true;
                //------------------------------------------------------------------------------------------------------
                //  Start timing
                wtcA.Reset(); wtcA.Start();  //wtcA.Restart(); Restart equivale a Reset + Start; Reset zera o cronometro
                dtmbeginB = DateTime.Now;   
                //------------------------------------------------------------------------------------------------------               
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            if ( btnRestart.Text.Equals("Pause")){
                wtcA.Stop();
                dtmendB = DateTime.Now;

                ElapsedTimeAcumulado += dtmendB - dtmbeginB;
                btnRestart.Text = "Restart";

                //  Show results
                lblEndA.Text = wtcA.ElapsedMilliseconds.ToString("N0");
                lblEndB.Text = (ElapsedTimeAcumulado).TotalMilliseconds.ToString("N0");
                btnCrono.Text = "Idle";
            }
            else
            {
                wtcA.Start();               // Start retoma a contagem do tempo sem zerar
                dtmbeginB = DateTime.Now;
                btnRestart.Text = "Pause";
                btnCrono.Text = "Running";
            }
        }
    }
}