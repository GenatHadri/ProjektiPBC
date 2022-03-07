using Projekti.Rilind;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EditFiles editFiles = null;
            try
            {
                editFiles = new EditFiles();

                //Lende
                editFiles.LexoLendet();
                //editFiles.ShkruajLendet();

                //Student
                editFiles.LexoStudentet();
                //editFiles.ShkruajStudentet();

                //Profesor
                editFiles.LexoProfesoret();
                //editFiles.ShkruajProfesoret();

                //Tema
                editFiles.LexoTemat();
                //editFiles.ShkruajTemat();

                //kerkesa
                editFiles.LexoKerkesat();
                //editFiles.ShkruajKerkesat();

                //komision
                editFiles.LexoKomisionet();
                //editFiles.ShkruajKomisionet();

                //Shqyretim
                //editFiles.Container();
                editFiles.LexoShqyretimet();
                //editFiles.ShkruajShqyretimet();

                //Takimet
                editFiles.LexoTakimet();
                //editFiles.ShkruajTakimet();

                //Vleresimi
                editFiles.LexoVleresimet();
                //editFiles.ShkruajVleresimet();

                //Queries
                //editFiles.printLendet();
                //editFiles.printStudentet();
                //editFiles.printProfesoret();
                //editFiles.printTema();
                //editFiles.printKerkesat();
                //editFiles.printKomisionet();
                //editFiles.printShqyretimet();
                //editFiles.printTakimet();
                //editFiles.printVleresimet();
                //editFiles.printStudentetMeNotenKaluese();
                //editFiles.printKerkesatEAnuluara();
                //editFiles.printKerkesatEPranuara();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (editFiles != null)
                {
                    editFiles.CloseAll();
                }
            }


        }

    }
}