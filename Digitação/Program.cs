using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Obtém o nome do processo atual (esta aplicação)
            string meuProcesso = Process.GetCurrentProcess().ProcessName;
            // Procura o processo atual na lista de processos que
            // estão a ser executados neste momento, no computador
            Process[] processos = Process.GetProcessesByName(meuProcesso);
            // Além desta instância, já existe mais alguma?
            if (processos != null && processos.Length > 2)
            {
                // Mostra uma mensagem, e termina esta instância...
                MessageBox.Show("Só pode haver um processo por vez!!", "O programa não irá abrir!");
            }
            else
            {
                // Permite executar a aplicação
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
        }
    }
}
