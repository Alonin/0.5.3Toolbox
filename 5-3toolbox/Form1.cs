using Memory;

namespace _5_3toolbox
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
         
        }
        bool ProcOpen = false;


        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("WoWClient");
            if (!ProcOpen)
            {
                Thread.Sleep(1000);
                return;
            }
                Thread.Sleep(1000);
                BGWorker.ReportProgress(0);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
           
        }

        private void BGWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.Text = "WoW Process Found!";
                float speed = m.ReadFloat("base+00A2961C,10,8,40,A0,E0");
                CurrentSpeedLabel.Text = ("Current speed is: " + speed.ToString());
                float CoordinateX = m.ReadFloat("base+00CB1FF8,8,198,A0,50");
                float CoordinateY = m.ReadFloat("base+00CB1FF8,8,1F0,10,8,4,2C,54");
                float CoordinateZ = m.ReadFloat("base+00A2EB50,1C,34,58");
                xPosLabel.Text = ("X: " + CoordinateX.ToString());
                yPosLabel.Text = ("Y: " + CoordinateY.ToString());
                zPosLabel.Text = ("Z: " + CoordinateZ.ToString());
            }

        }

        private void BGWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }


        private void teleportButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+00CB1FF8,8,198,A0,50", "float", coordXBox.Text);
            m.WriteMemory("base+00CB1FF8,8,1F0,10,8,4,2C,54", "float", coordYBox.Text);
            m.WriteMemory("base+00A2EB50,1C,34,58", "float", coordZBox.Text);
        }

        private void ProcOpenLabel_TextChanged(object sender, EventArgs e)
        {
            float CoordinateX = m.ReadFloat("base+00CB1FF8,8,198,A0,50");
            float CoordinateY = m.ReadFloat("base+00CB1FF8,8,1F0,10,8,4,2C,54");
            float CoordinateZ = m.ReadFloat("base+00A2EB50,1C,34,58");
            coordXBox.Text = CoordinateX.ToString();
            coordYBox.Text = CoordinateY.ToString();
            coordZBox.Text = CoordinateZ.ToString();
        }

   

        private void ModifySpeedButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+00A2961C,10,8,40,A0,E0", "float", speedbox.Text);
        }

        private void AlwaysOnTopCB_CheckedChanged(object sender, EventArgs e)
        {
            if(AlwaysOnTopCB.Checked)
            this.TopMost = true;
            else
                this.TopMost = false;
        }
    }
}