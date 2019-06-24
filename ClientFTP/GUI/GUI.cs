using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFTP
{
    class GUI
    {
        public static void Init()
        {
            new Task(() =>
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }).Start();
        }
    }
}
