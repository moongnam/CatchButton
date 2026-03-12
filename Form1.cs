using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // Random을 클래스 필드로 이동하여 동일 시드 문제 방지
        private readonly Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        // 버튼에 마우스가 진입할 때마다 나오는 이벤트
        private void Run_MouseEnter(object sender, EventArgs e)
        {

            // 도망 다닐 때 나는 소리 재생
            SystemSounds.Beep.Play();

            // 1. 난수 생성기 준비 (클래스 필드 rd 사용)

            // 2. 가용 영역 계산(버튼이 폼 테두리에 걸리지않게 보호)
            // ClientSize는 타이틀바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - Run.Width;
            int maxY = this.ClientSize.Height - Run.Height;

            // 3. 랜덤 좌표 추출(0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 위치 할당(새로운 Point 객체 생성)
            Run.Location = new Point(nextX, nextY);

            // 5. 시각적 피드백(폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }


        // 버튼에 마우스가 클릭될 때마다 나오는 이벤트
        private void Run_MouseClick(object sender, MouseEventArgs e)
        {
            // 잡았을 때 나오는 소리 재생
            SystemSounds.Asterisk.Play();

            // 메시지 박스 띄우기
            MessageBox.Show("축하합니다~!");

        }
    }
}
