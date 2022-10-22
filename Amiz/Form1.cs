namespace Amiz
{
    public partial class Form1 : Form
    {
        Graphics? G;
        Pen? pen;
        int times;
        int timesB;
        bool isrecord;
        int idx;
        public Form1()
        {
            InitializeComponent();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            times++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isrecord)
            {
                G.DrawLine(pen, new Point(idx - 1, timesB),new Point(idx,times));
                idx ++;
                timesB = times;
                label1.Text = times.ToString();
                if(times > Convert.ToInt32(label2.Text))
                {
                    label2.Text = times.ToString();
                }
                times = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx = 2;
            label2.Text = "0";
            isrecord = true;
            G = pictureBox1.CreateGraphics();
            G.Clear(Color.AliceBlue);
            pen = new Pen(Color.Black, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用本软件!\n点击Start后在右侧粗滚轮处滚动即可使用,再次点击Start可重置");
            times = 0;
            isrecord = false;
            idx = 2;
            timesB = 0;
        }
    }
}