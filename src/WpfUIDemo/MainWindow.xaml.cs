using System.Windows;
using System.Windows.Input;

namespace Walterlv.Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TitleHeader_MouseMove(object sender, MouseEventArgs e)
        {
            // 鼠标按下的时候，可以拖拽窗口。
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
