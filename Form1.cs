using System.Collections.Specialized;
using System.Media;

namespace WinFormsApp_3
{
    public partial class 버튼잡기게임 : Form
    {
        private int score = 0; // 점수 저장
        private Random rand = new Random(); // 랜덤 좌표 생성용
        public 버튼잡기게임()
        {
            InitializeComponent();
            UpdateTitleScore(); // 시작 시 제목 표시줄 초기화
        }
        private void UpdateScoreDisplay()
        {
            this.Text = "점수: " + score + "점 - 버튼 잡기 게임";
        }
        // 2. 점수를 제목 표시줄에 업데이트하는 공통 함수
        private void UpdateTitleScore()
        {
            this.Text = $"현재 점수: {score}점 | 마우스를 피해 도망가는 버튼을 잡아보세요!";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void target_MouseEnter(object sender, EventArgs e)
        {
            // 점수 감점 및 업데이트
            score -= 10;
            UpdateTitleScore();

            SystemSounds.Beep.Play();

            Random rd = new Random();

            int maxX = this.ClientSize.Width - target.Width;

            int maxY = this.ClientSize.Height - target.Height;

            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);

            target.Location = new Point(nextX, nextY);

            //this.Text = $"버튼위치: ({nextX}, {nextY})";
         
        }

        private void target_Click(object sender, EventArgs e)
        {
            // 점수 가점 및 업데이트
            score += 100;
            UpdateTitleScore();

            target.Width = (int)(target.Width * 0.9);
            target.Height = (int)(target.Height * 0.9);

            SystemSounds.Asterisk.Play();

            //MessageBox.Show("축하합니다!");

            
            //Application.Exit();
        }
    }
}
