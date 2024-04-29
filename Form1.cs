namespace HideME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                timer1.Start();
                
                this.TopMost = true;
                this.Size = new Size(1920, 1080);
                this.Top = 0;
                this.Left = 0;
                TimeShow.Left = 1920 / 5;
                TimeShow.Top = 1080 / 4 + 200;
                TimeShow.Visible = true;
                TimeShow.Text = DateTime.Now.ToString();
            }
            else
            {
                timer1.Enabled = true;
                TimeShow.Visible = false;
                this.TopMost = true;
                this.Size = new Size(154, 112);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.TopMost = true;
            checkBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeShow.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
