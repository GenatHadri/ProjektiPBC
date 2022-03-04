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
                Console.WriteLine("aa");
                editFiles.Sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Lenda.txt");
                Console.WriteLine("bb");
                editFiles.Container();
                Console.WriteLine("cc");
                editFiles.ShkruajLendet();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                try
                {
                    editFiles.CloseAll();
                }
                catch 
                {
                
                }
                finally
                {
                    Console.WriteLine("Files are closed");
                }
            }


        }

    }
}