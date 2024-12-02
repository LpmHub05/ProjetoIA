using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroIA
{

    public static class function
    {
        public static string datalanc(string ano)
        {
           int anolanc = Convert.ToInt32(ano);
            int calc = 2024 - anolanc;
            MessageBox.Show($"A idade da IA é de: {calc} anos.");
            string result = Convert.ToString(calc);
            return result;
        }
    }
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
