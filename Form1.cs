using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TrafficLightController
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            InitializeTrafficLight();
        }

        private void InitializeTrafficLight()
        {
            // Ustawienia pocz¹tkowe paneli (œwiate³ sygnalizacji)
            redPanel.BackColor = Color.Gray;
            yellowPanel.BackColor = Color.Gray;
            greenPanel.BackColor = Color.Gray;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                ThreadPool.QueueUserWorkItem(_ => RunTrafficLightCycle());
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            ResetTrafficLight();
        }


        private void ResetTrafficLight()
        {
            // Wy³¹czenie wszystkich œwiate³
            Invoke(new Action(() =>
            {
                redPanel.BackColor = Color.Gray;
                yellowPanel.BackColor = Color.Gray;
                greenPanel.BackColor = Color.Gray;
            }));
        }

        private void RunTrafficLightCycle()
        {
            while (isRunning)
            {
                // Œwiat³o czerwone
                UpdateLightPanels(Color.Red, Color.Gray, Color.Gray);
                Thread.Sleep((int)numericRed.Value * 1000);

                // Œwiat³o ¿ó³te
                UpdateLightPanels(Color.Gray, Color.Yellow, Color.Gray);
                Thread.Sleep((int)numericYellow.Value * 1000);

                // Œwiat³o zielone
                UpdateLightPanels(Color.Gray, Color.Gray, Color.Green);
                Thread.Sleep((int)numericGreen.Value * 1000);
            }
        }

        private void UpdateLightPanels(Color redColor, Color yellowColor, Color greenColor)
        {
            // Aktualizacja kolorów paneli w interfejsie graficznym
            Invoke(new Action(() =>
            {
                redPanel.BackColor = redColor;
                yellowPanel.BackColor = yellowColor;
                greenPanel.BackColor = greenColor;
            }));
        }

        private void redPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yellowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void greenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericYellow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
