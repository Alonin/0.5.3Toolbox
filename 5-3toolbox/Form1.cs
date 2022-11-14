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
         
              
            }

        }

        private void BGWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }


        private void teleportButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+00CB1FF8,8,198,A0,50", "float", coordXBox.Text);
            m.WriteMemory("base+009C754C,C,40,54", "float", coordYBox.Text);
            m.WriteMemory("base+00A2EB50,1C,34,58", "float", coordZBox.Text);
        }

        private void ProcOpenLabel_TextChanged(object sender, EventArgs e)
        {
            float CoordinateX = m.ReadFloat("base+00CB1FF8,8,198,A0,50");
            float CoordinateY = m.ReadFloat("base+009C754C,C,40,54");
            float CoordinateZ = m.ReadFloat("base+00A2EB50,1C,34,58");
            coordXBox.Text = CoordinateX.ToString();
            coordYBox.Text = CoordinateY.ToString();
            coordZBox.Text = CoordinateZ.ToString();
        }
    }
}