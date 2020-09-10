using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login200_D
{
    static class Program
    {

        public delegate void StateObs(State s);
        public delegate void InputHandler(State s, string str);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CredentialsD model = new CredentialsD("Alice", "Wonderland");
            ControllerD controller = new ControllerD(model);
            LoginD view = new LoginD(controller.handleEvents);
            controller.registerObs(view.DisplayState);

            Application.Run(view);
        }
    }
}
