using System.Collections.Specialized;

namespace WinFormsApp_3
{
    public partial class 버튼잡기게임 : Form
    {
        public 버튼잡기게임()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void target_MouseEnter(object sender, EventArgs e)
        {

            Random rd = new Random();

            int maxX = this.ClientSize.Width - target.Width;

            int maxY = this.ClientSize.Height - target.Height;

            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);

            target.Location = new Point(nextX, nextY);

            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }

        private void target_Click(object sender, EventArgs e)
        {
            MessageBox.Show("나를 잡았구나 축하해!");

            
            Application.Exit();
        }
    }
}
