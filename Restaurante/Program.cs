using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        private static readonly SerializationService serializationService = new SerializationService();
        private const string TablesDirectory = "Tables";
        private const string TablesFileName = "tables.dat";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(CloseApp);
            Application.Run(new Tables());
        }

        private static void CloseApp(object sender, EventArgs e)
        {
            for (int i = 0; i < Repository.Instancia.resurantTables.Count; i++)
            {
                if (Repository.Instancia.resurantTables[i].State.Contains(tablesStates((int)States.INPROCESS)))
                {
                    Repository.Instancia.resurantTables[i].State = tablesStates((int)States.RESUME_PROCESS);
                    serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);
                }
            }
        }


        public static string tablesStates(int state)
        {
            string labelState = "";
            switch (state)
            {
                case (int)(States.AVAILABLE):
                    labelState = "Disponible";
                    break;
                case (int)(States.INPROCESS):
                    labelState = "En proceso de atención";
                    break;
                case (int)(States.RESUME_PROCESS):
                    labelState = "Reanudar proceso de atención";
                    break;

                case (int)(States.ATTENDED):
                    labelState = "Atendida";
                    break;

                default:
                    labelState = "Disponible";
                    break;

            }
            return labelState;
        }
    }
}
