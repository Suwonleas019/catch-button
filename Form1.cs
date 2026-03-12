using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WinFormsApp_3
{
    public partial class 버튼잡기게임 : Form
    {


        public 버튼잡기게임()
        {
            InitializeComponent();
        }
        int score = 0;
        int missCount = 0; // 놓친 횟수 카운트
        private void Form1_Load(object? sender, EventArgs e)
        {

        }

        private void target_MouseEnter(object? sender, EventArgs e)
        {
            missCount++; //놓친 횟수 증가
            score -= 10; // 10점 감점
            this.Text = "현재 점수: " + score;
            this.Text = "놓친 횟수; " + missCount; // 폼 제목 업데이트클릭 실패 시
            Random rand = new Random();

            // 2. 버튼이 움직일 수 있는 최대 범위 계산 (폼의 크기 - 버튼의 크기)
            int maxX = this.ClientSize.Width - target.Width;
            int maxY = this.ClientSize.Height - target.Height;

            // 3. 범위 내에서 무작위 좌표 생성
            int nextX = rand.Next(0, maxX);
            int nextY = rand.Next(0, maxY);

            // 4. 버튼 위치 변경
            target.Location = new Point(nextX, nextY);
            // 20번 놓치면 게임 오버
            if (missCount >= 20)
            {
                GameOver();
                return; // 더 이상 도망가지 않게 중단
            }

         
        }

        // [게임 종료 처리]
        private void GameOver()
        {
            MessageBox.Show("Game Over");
            target.Enabled = false; // 도망가는 버튼 비활성화
            btnRestart.Visible = true;

            // '다시 시작' 버튼 생성 또는 활성화
            // (이미 폼에 다시 시작 버튼을 만들어 두었다면 btnRestart.Visible = true; 등으로 처리)
        }

        // [다시 시작 버튼 클릭 시] 초기화 로직
       

        private void target_Click(object? sender, EventArgs e)
        {
            score += 100; // 100점 추가 클릭 성공시
            this.Text = "현재 점수: " + score; // 폼 제목 업데이트
            target.Width = (int)(target.Width * 0.9);
            target.Height = (int)(target.Height * 0.9);
            Random rand = new Random();

            // 2. 버튼이 움직일 수 있는 최대 범위 계산 (폼의 크기 - 버튼의 크기)
            int maxX = this.ClientSize.Width - target.Width;
            int maxY = this.ClientSize.Height - target.Height;

            // 3. 범위 내에서 무작위 좌표 생성
            int nextX = rand.Next(0, maxX);
            int nextY = rand.Next(0, maxY);

            // 4. 버튼 위치 변경
            target.Location = new Point(nextX, nextY);
        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            // 점수 및 카운트 초기화
            score = 0;
            missCount = 0;
            this.Text = "점수: 0 | 놓친 횟수: 0/20";

            // 버튼 복구
            target.Enabled = true;
            target.Width = 300;  // 처음 크기로 복구 (예시)
            target.Height = 200;
            target.Location = new Point(100, 100); // 처음 위치로 복구
            btnRestart.Visible = false;
        }
    }
}