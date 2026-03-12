namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수 생성기 준비
            Random rd = new Random();

            // 2. 가용 영역 계산(버튼이 폼 테두리에 걸리지않게 보호)
            // ClientSize는 타이틀바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width-150;
            int maxY = this.ClientSize.Height-60;

            // 3. 랜덤 좌표 추출(0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 위치 할당(새로운 Point 객체 생성)
            Run.Location = new Point(nextX, nextY);

            // 5. 시각적 피드백(폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
