using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class AppImagePanel : UserControl
    {
        private static AppImagePanel _instance;

        public AppImagePanel()
        {
            InitializeComponent();
        }

        public static AppImagePanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppImagePanel();
                return _instance;
            }
        }
    }
}
