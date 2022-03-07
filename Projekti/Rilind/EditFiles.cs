using Projekti.Rilind;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class EditFiles
    {
        List<Profesori> profesoret = new List<Profesori>();
        List<Lenda> lendet = new List<Lenda>();
        List<Studenti> studentet = new List<Studenti>();
        List<Tema> temat = new List<Tema>();
        List<Komisioni> komisionet = new List<Komisioni>();
        List<Kerkesa> kerkesat = new List<Kerkesa>();
        List<Shqyretimi> shqyretimet = new List<Shqyretimi>();
        List<Takimet> takimet = new List<Takimet>();
        List<Vleresimi> vleresimet = new List<Vleresimi>();
        StreamReader sr;
        StreamWriter sw;

        public EditFiles()
        {
        }

        public StreamReader Sr { get => sr; set => sr = value; }
        public StreamWriter Sw { get => sw; set => sw = value; }

        //public void Container()
        //{
        //Lenda l1 = new Lenda("Matematike", 5, true);
        //Lenda l2 = new Lenda("Algoritme", 5, true);
        //Lenda l3 = new Lenda("Databaze", 5, true);
        //Lenda l4 = new Lenda("TZP", 5, true);
        //Lenda l5 = new Lenda("WEB", 5, true);
        //Lenda l6 = new Lenda("Arkitekture e kompjuterave", 5, true);
        //Lenda l7 = new Lenda("SHK1", 5, true);
        //Lenda l8 = new Lenda("SHK2", 5, true);
        //Lenda l9 = new Lenda("Hyrje ne WEB", 5, true);
        //Lenda l10 = new Lenda("BTI", 5, true);
        //Lenda l11 = new Lenda("BIEE", 5, true);
        //Lenda l12 = new Lenda("Sisteme te sinjaleve", 5, true);
        ////lendet.Add(l1);
        ////lendet.Add(l2);
        ////lendet.Add(l3);
        ////lendet.Add(l4);
        ////lendet.Add(l5);
        ////lendet.Add(l6);
        ////lendet.Add(l7);
        ////lendet.Add(l8);
        ////lendet.Add(l9);
        ////lendet.Add(l10);
        ////lendet.Add(l11);
        ////lendet.Add(l12);

        //Profesori p1 = new Profesori(10, "Blerim", "Gashi", "bg@gmail.com", "+38312345678", "Master");
        //Profesori p2 = new Profesori(11, "Xhelal", "Jashari", "xj@gmail.com", "+38312345678", "Master");
        //Profesori p3 = new Profesori(12, "Edmond", "Jahjaga", "ej@gmail.com", "+38312345678", "Master");
        //Profesori p4 = new Profesori(13, "Betim", "Gashi", "betim.g@gmail.com", "+38312345678", "Master");
        //Profesori p5 = new Profesori(14, "Arber", "Kadriu", "ak@gmail.com", "+38312345678", "Master");
        //Profesori p6 = new Profesori(15, "Artan", "Berisha", "ab@gmail.com", "+38312345678", "Master");
        //Profesori p7 = new Profesori(16, "Vesa", "Morina", "vm@gmail.com", "+38312345678", "Master");
        //Profesori p8 = new Profesori(17, "Ermir", "Rugova", "er@gmail.com", "+38312345678", "Master");
        ////profesoret.Add(p1);
        ////profesoret.Add(p2);
        ////profesoret.Add(p3);
        ////profesoret.Add(p4);
        ////profesoret.Add(p5);
        ////profesoret.Add(p6);
        ////profesoret.Add(p7);
        ////profesoret.Add(p8);

        //Studenti s1 = new Studenti(20, "Genat", "Hadri", "gh@gmail.com", "CSE");
        //Studenti s2 = new Studenti(21, "Rilind", "Bejta", "rb@gmail.com", "CSE");
        //Studenti s3 = new Studenti(22, "Alban", "Selmanaj", "as@gmail.com", "CSE");
        //Studenti s4 = new Studenti(23, "Valmire", "Gashi", "vg@gmail.com", "CSE");
        //Studenti s5 = new Studenti(24, "Erion", "Bytyqi", "eb@gmail.com", "CSE");
        //Studenti s6 = new Studenti(25, "Qendrim", "Sadriaj", "qs@gmail.com", "CSE");
        //Studenti s7 = new Studenti(26, "Nderim", "Qerimi", "nq@gmail.com", "CSE");
        //Studenti s8 = new Studenti(27, "Blend", "Zhegrova", "bz@gmail.com", "CSE");
        //Studenti s9 = new Studenti(28, "Adhurim", "Krasniqi", "ak@gmail.com", "CSE");
        //Studenti s10 = new Studenti(29, "Fidan", "Hashani", "hs@gmail.com", "CSE");
        //Studenti s11 = new Studenti(30, "Lir", "Ballata", "lb@gmail.com", "CSE");
        //Studenti s12 = new Studenti(31, "Endrit", "Tafilaj", "ef@gmail.com", "CSE");
        //Studenti s13 = new Studenti(32, "Leonard", "Zaberxha", "lz@gmail.com", "CSE");
        //Studenti s14 = new Studenti(33, "Serafina", "Berbatovci", "sb@gmail.com", "CSE");
        //Studenti s15 = new Studenti(34, "Florentine", "Hamiti", "fh@gmail.com", "CSE");
        //Studenti s16 = new Studenti(35, "Bleona", "Curri", "bc@gmail.com", "CSE");
        //Studenti s17 = new Studenti(36, "Urata", "Sadiku", "us@gmail.com", "CSE");
        //Studenti s18 = new Studenti(37, "Arjeta", "Zabeli", "az@gmail.com", "CSE");
        ////studentet.Add(s1);
        ////studentet.Add(s2);
        ////studentet.Add(s3);
        ////studentet.Add(s4);
        ////studentet.Add(s5);
        ////studentet.Add(s6);
        ////studentet.Add(s7);
        ////studentet.Add(s8);
        ////studentet.Add(s9);
        ////studentet.Add(s10);
        ////studentet.Add(s11);
        ////studentet.Add(s12);
        ////studentet.Add(s13);
        ////studentet.Add(s14);
        ////studentet.Add(s15);
        ////studentet.Add(s16);
        ////studentet.Add(s17);
        ////studentet.Add(s18);

        //Tema t1 = new Tema("Funksionet Aritmetike");
        //Tema t2 = new Tema("Ndertimi i Web Aplikacionit per shitje online");
        //Tema t3 = new Tema("Data Analysis");
        //Tema t4 = new Tema("Perdorimi i teknologjis me matematik");
        //Tema t5 = new Tema("Aplikimi i AI ne biznes");
        //Tema t6 = new Tema("Aplikimi i teknologjive HTML");
        //Tema t7 = new Tema("Analiza e sigurise ne rrjete kompjuterike");
        //Tema t8 = new Tema("Monitorimi i shendetit personal");
        ////temat.Add(t1);
        ////temat.Add(t2);
        ////temat.Add(t3);
        ////temat.Add(t4);
        ////temat.Add(t5);
        ////temat.Add(t6);
        ////temat.Add(t7);
        ////temat.Add(t8);

        //Kerkesa k1 = new Kerkesa(100, p1, s1, t1);
        //Kerkesa k2 = new Kerkesa(222, p2, s2, t2);
        //Kerkesa k3 = new Kerkesa(312, p3, s3, t4);
        //Kerkesa k4 = new Kerkesa(423, p4, s4, t2);
        //Kerkesa k5 = new Kerkesa(50, p5, s5, t3);
        //Kerkesa k6 = new Kerkesa(61, p6, s6, t7);
        //Kerkesa k7 = new Kerkesa(72, p7, s7, t8);
        //Kerkesa k8 = new Kerkesa(82, p8, s8, t4);
        //Kerkesa k9 = new Kerkesa(99, p2, s9, t6);
        //Kerkesa k10 = new Kerkesa(102, p1, s11, t5);
        //Kerkesa k11 = new Kerkesa(111, p5, s15, t1);
        ////kerkesat.Add(k1);
        ////kerkesat.Add(k2);
        ////kerkesat.Add(k3);
        ////kerkesat.Add(k4);
        ////kerkesat.Add(k5);
        ////kerkesat.Add(k6);
        ////kerkesat.Add(k7);
        ////kerkesat.Add(k8);
        ////kerkesat.Add(k9);
        ////kerkesat.Add(k10);
        ////kerkesat.Add(k11);

        //Komisioni komisioni1 = new Komisioni(30, profesoret);
        //Komisioni komisioni2 = new Komisioni(31, profesoret);
        //Komisioni komisioni3 = new Komisioni(32, profesoret);
        //Komisioni komisioni4 = new Komisioni(33, profesoret);
        //Komisioni komisioni5 = new Komisioni(34, profesoret);
        //Komisioni komisioni6 = new Komisioni(35, profesoret);
        //Komisioni komisioni7 = new Komisioni(36, profesoret);
        //Komisioni komisioni8 = new Komisioni(37, profesoret);
        //Komisioni komisioni9 = new Komisioni(38, profesoret);
        //Komisioni komisioni10 = new Komisioni(39, profesoret);
        //Komisioni komisioni11 = new Komisioni(40, profesoret);
        ////komisionet.Add(komisioni1);
        ////komisionet.Add(komisioni2);
        ////komisionet.Add(komisioni3);
        ////komisionet.Add(komisioni4);
        ////komisionet.Add(komisioni5);
        ////komisionet.Add(komisioni6);
        ////komisionet.Add(komisioni7);
        ////komisionet.Add(komisioni8);
        ////komisionet.Add(komisioni9);
        ////komisionet.Add(komisioni10);
        ////komisionet.Add(komisioni11);

        //Shqyretimi shqyretimi1 = new Shqyretimi(komisioni1, k1, true);
        //Shqyretimi shqyretimi2 = new Shqyretimi(komisioni3, k2, true);
        //Shqyretimi shqyretimi3 = new Shqyretimi(komisioni2, k3, true);
        //Shqyretimi shqyretimi4 = new Shqyretimi(komisioni4, k4, true);
        //Shqyretimi shqyretimi5 = new Shqyretimi(komisioni5, k5, false);
        //Shqyretimi shqyretimi6 = new Shqyretimi(komisioni6, k6, true);
        //Shqyretimi shqyretimi7 = new Shqyretimi(komisioni7, k7, true);
        //Shqyretimi shqyretimi8 = new Shqyretimi(komisioni11, k11, false);
        //Shqyretimi shqyretimi9 = new Shqyretimi(komisioni8, k8, true);
        //Shqyretimi shqyretimi10 = new Shqyretimi(komisioni9, k9, false);
        //Shqyretimi shqyretimi11 = new Shqyretimi(komisioni10, k10, true);
        ////shqyretimet.Add(shqyretimi1);
        ////shqyretimet.Add(shqyretimi2);
        ////shqyretimet.Add(shqyretimi3);
        ////shqyretimet.Add(shqyretimi4);
        ////shqyretimet.Add(shqyretimi5);
        ////shqyretimet.Add(shqyretimi6);
        ////shqyretimet.Add(shqyretimi7);
        ////shqyretimet.Add(shqyretimi8);
        ////shqyretimet.Add(shqyretimi9);
        ////shqyretimet.Add(shqyretimi10);
        ////shqyretimet.Add(shqyretimi11);

        //Takimet takimi1 = new Takimet(k1, 12, shqyretimet);
        //Takimet takimi2 = new Takimet(k2, 12, shqyretimet);  //Rilind Bejta , kerkesa == false
        //Takimet takimi3 = new Takimet(k4, 11, shqyretimet);
        //Takimet takimi4 = new Takimet(k3, 12, shqyretimet);
        //Takimet takimi5 = new Takimet(k6, 12, shqyretimet);
        //Takimet takimi6 = new Takimet(k7, 11, shqyretimet);
        ////takimet.Add(takimi1);
        ////takimet.Add(takimi2);
        ////takimet.Add(takimi3);
        ////takimet.Add(takimi4);
        ////takimet.Add(takimi5);
        ////takimet.Add(takimi6);

        //Vleresimi v1 = new Vleresimi(komisioni9, k1, 10, takimet);
        //Vleresimi v2 = new Vleresimi(komisioni3, k5, 8, takimet);
        //Vleresimi v3 = new Vleresimi(komisioni2, k2, 6, takimet);
        //Vleresimi v4 = new Vleresimi(komisioni5, k6, 7, takimet);  //Qendrim Sadriaj !=12 takime 
        ////vleresimet.Add(v1);
        ////vleresimet.Add(v2);
        ////vleresimet.Add(v3);
        ////vleresimet.Add(v4);
        //}

        //print ----------------------------------------------------------------------

        public void printKerkesatEPranuara()
        {
            Console.Clear();
            Console.WriteLine("Kerkesat e pranuara nga komisioni:");
            foreach(Shqyretimi s in shqyretimet)
            {
                if(s.Vendimi1 == true)
                {
                    Console.WriteLine(s.Kerkesa);
                }
            }
        }

        public void printKerkesatEAnuluara()
        {
            Console.Clear();
            Console.WriteLine("Kerkesat e anuluara nga komisioni:");
            foreach(Shqyretimi s in shqyretimet)
            {
                if(s.Vendimi1 == false)
                {
                    Console.WriteLine(s.Kerkesa);
                }
            }
        }

        public void printStudentetMeNotenKaluese()
        {
            Console.Clear();
            Console.WriteLine("Studentet qe kane noten kaluese jane:");
            foreach (Vleresimi v in vleresimet)
            {
                if (v.Nota1 > 5)
                {
                    Console.WriteLine(v.Kerkesa.Studenti);
                }
            }
        }

        public void printLendet()
        {
            Console.Clear();
            Console.WriteLine("Lendet: ");
            foreach (Lenda l in lendet)
            {
                Console.WriteLine(l);
            }
        }

        public void printTakimet()
        {
            Console.Clear();
            Console.WriteLine("Takimet e mbajtura: ");
            foreach (Takimet t in takimet)
            {
                Console.WriteLine(t);
            }
        }

        public void printVleresimet()
        {
            Console.Clear();
            Console.WriteLine("Vleresimet e perfunduara deri me tani:");
            foreach (Vleresimi v in vleresimet)
            {
                Console.WriteLine(v);
            }
        }

        public void printShqyretimet()
        {
            Console.Clear();
            Console.WriteLine("Shqyretimet e temave nga komisione te ndryshme:");
            foreach (Shqyretimi s in shqyretimet)
            {
                Console.WriteLine(s);
            }
        }

        public void printKerkesat()
        {
            Console.Clear();
            Console.WriteLine("Kerkesat e parashtuara jane:");
            foreach (Kerkesa k in kerkesat)
            {
                Console.WriteLine(k);
            }
        }

        public void printTema()
        {
            Console.Clear();
            Console.WriteLine("Temat e sugjeruara nga profesori: ");
            foreach (Tema t in temat)
            {
                Console.WriteLine(t);
            }
        }

        public void printProfesoret()
        {
            Console.Clear();
            Console.WriteLine("Profesoret e fakultetit: ");
            foreach (Profesori p in profesoret)
            {
                Console.WriteLine(p);
            }
        }

        public void printStudentet()
        {
            Console.Clear();
            Console.WriteLine("Studentet: ");
            foreach (Studenti s in studentet)
            {
                Console.WriteLine(s);
            }
        }

        public void printKomisionet()
        {
            Console.Clear();
            Console.WriteLine("Komisionet: ");
            foreach (Komisioni k in komisionet)
            {
                Console.WriteLine(k);
            }
        }

        //lexo ----------------------------------------------------------------------
        public void LexoLendet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Lenda.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.Emri + ";" + this.Ects;
                string[] atributet = line.Split(';');
                string emriLenda = atributet[0];
                int ects = Int32.Parse(atributet[1]);
                string validim = atributet[2] == "Obligative" ? "true" : "false";
                bool obligative = Boolean.Parse(validim);

                Lenda l = new Lenda(emriLenda, ects, obligative);
                lendet.Add(l);
            }
            sr.Close();
        }

        public void LexoStudentet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Studenti.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.Id1 + ";" + this.Emri1 + ";" + this.Mbiemri1 + ";" + this.Email1 + ";" + this.Departamenti;
                int id = Int32.Parse(line.Split(';')[0]);
                string emri = line.Split(';')[1];
                string mbiemri = line.Split(';')[2];
                string email = line.Split(';')[3];
                string departamenti = line.Split(';')[4];

                Studenti s = new Studenti(id, emri, mbiemri, email, departamenti);
                studentet.Add(s);
            }
            sr.Close();
        }

        public void LexoProfesoret()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Profesori.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.Id1 + ";" + this.Emri1 + ";" + this.Mbiemri1 + ";" + this.Email1 + ";" + this.NrTel1 + ";" + this.GradaAkademike;
                int id = Int32.Parse(line.Split(';')[0]);
                string emri = line.Split(';')[1];
                string mbiemri = line.Split(';')[2];
                string email = line.Split(';')[3];
                string nrTel = line.Split(';')[4];
                string gradaAkademike = line.Split(';')[5];

                Profesori p = new Profesori(id, emri, mbiemri, email, nrTel, gradaAkademike);
                profesoret.Add(p);
            }
            sr.Close();
        }

        public void LexoTemat()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Tema.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.Emri + ";" + this.TemaEcts1;
                string emri = line.Split(';')[0];
                int ects = Int32.Parse(line.Split(';')[1]);

                Tema t = new Tema(emri);
                temat.Add(t);
            }
            sr.Close();
        }

        public void LexoKerkesat()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Kerkesa.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.profesori.Id1 + ";" + this.studenti.Id1 + ";" + this.tema.Emri1;
                int kerkesaId = Int32.Parse(line.Split(';')[0]);
                int profesoriId = Int32.Parse(line.Split(';')[1]);
                int studentiId = Int32.Parse(line.Split(';')[2]);
                string emriTema = line.Split(';')[3];

                Profesori p = null;
                Studenti s = null;
                Tema t = null;
                foreach (Profesori profesori in profesoret)
                {
                    if (profesoriId == profesori.Id1)
                    {
                        p = profesori;
                    }
                }
                foreach (Studenti studenti in studentet)
                {
                    if (studentiId == studenti.Id1)
                    {
                        s = studenti;
                    }
                }
                foreach (Tema tema in temat)
                {
                    if (emriTema == tema.Emri1)
                    {
                        t = tema;
                    }
                }

                Kerkesa k = new Kerkesa(kerkesaId, p, s, t);
                kerkesat.Add(k);
            }
            sr.Close();
        }

        public void LexoKomisionet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Komisioni.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                int komisioniId = Int32.Parse(line.Split(';')[0]);
                int p1 = Int32.Parse(line.Split(';')[1]);
                int p2 = Int32.Parse(line.Split(';')[2]);
                int p3 = Int32.Parse(line.Split(';')[3]);

                Komisioni k = new Komisioni(komisioniId, profesoret);
                komisionet.Add(k);
            }
            sr.Close();
        }

        public void LexoShqyretimet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Shqyretimi.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //this.komisioni.Id1 + ";" + this.kerkesa.Id1 + ";" + (this.Vendimi ? "Pranohet" : "Anulohet");
                int komisioniId = Int32.Parse(line.Split(';')[0]);
                int kerkesaId = Int32.Parse(line.Split(';')[1]);
                string validim = line.Split(';')[2] == "Pranohet" ? "true" : "false";
                bool vendimi = Boolean.Parse(validim);
                Komisioni k = null;
                Kerkesa ke = null;

                for (int i = 0; i < komisionet.Count; i++)
                {
                    if (komisioniId == komisionet[i].Id1)
                    {
                        k = komisionet[i];
                    }
                }
                for (int i = 0; i < kerkesat.Count; i++)
                {
                    if (kerkesaId == kerkesat[i].Id1)
                    {
                        ke = kerkesat[i];
                    }
                }

                Shqyretimi s = new Shqyretimi(k, ke, vendimi);
                shqyretimet.Add(s);
            }
            sr.Close();
        }

        public void LexoVleresimet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Vleresimi.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                int komisioniId = Int32.Parse(line.Split(';')[0]);
                int kerkesaId = Int32.Parse(line.Split(';')[1]);
                string validim = line.Split(';')[2];
                int nota = 0;
                if (validim != " Nuk eshte vleresuar!")
                {
                    nota = Int32.Parse(line.Split(';')[2]);
                }
                else
                {
                    nota = 5;
                }

                Komisioni k = null;
                Kerkesa ke = null;
                for (int i = 0; i < komisionet.Count; i++)
                {
                    if (komisioniId == komisionet[i].Id1)
                    {
                        k = komisionet[i];
                    }
                }
                for (int i = 0; i < kerkesat.Count; i++)
                {
                    if (kerkesaId == kerkesat[i].Id1)
                    {
                        ke = kerkesat[i];
                    }
                }

                Vleresimi v = new Vleresimi(k, ke, nota, takimet);
                vleresimet.Add(v);
            }
            sr.Close();
        }

        public void LexoTakimet()
        {
            sr = new StreamReader(@"C:\Users\PC\Desktop\editFiles\Takimet.txt");
            string line = String.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                int kerkesaId = Int32.Parse(line.Split(';')[0]);
                int nrTakimeve = Int32.Parse(line.Split(';')[1]);

                Kerkesa k = null;
                for (int i = 0; i < kerkesat.Count; i++)
                {
                    if (kerkesaId == kerkesat[i].Id1)
                    {
                        k = kerkesat[i];
                    }
                }

                Takimet t = new Takimet(k, nrTakimeve, shqyretimet);
                takimet.Add(t);
            }
        }

        //shkruaj ----------------------------------------------------------------------
        public void ShkruajLendet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Lenda.txt");
            foreach (Lenda l in lendet)
            {
                sw.WriteLine(((Lenda)l).toString());
                //sw.WriteLine(l);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajStudentet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Studenti.txt");
            foreach (Studenti s in studentet)
            {
                sw.WriteLine(((Studenti)s).toString());
                //sw.WriteLine(s);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajProfesoret()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Profesori.txt");
            foreach (Profesori p in profesoret)
            {
                sw.WriteLine(((Profesori)p).toString());
                //sw.WriteLine(p);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajTemat()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Tema.txt");
            foreach (Tema t in temat)
            {
                sw.WriteLine(((Tema)t).toString());
                //sw.WriteLine(t);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajKerkesat()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Kerkesa.write.txt");
            foreach (Kerkesa k in kerkesat)
            {
                sw.WriteLine(((Kerkesa)k).toString());
                //sw.WriteLine(k);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajKomisionet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Komisioni.txt");
            foreach (Komisioni k in komisionet)
            {
                sw.WriteLine(((Komisioni)k).toString());
                //sw.WriteLine(k);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajShqyretimet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Shqyretimi.txt");
            foreach (Shqyretimi s in shqyretimet)
            {
                sw.WriteLine(((Shqyretimi)s).toString());
                //sw.WriteLine(s);
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajTakimet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Takimet.txt");
            foreach (Takimet t in takimet)
            {
                sw.WriteLine(((Takimet)t).toString());
            }
            sw.Flush();
            sw.Close();
        }

        public void ShkruajVleresimet()
        {
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Vleresimi.write.txt");
            foreach (Vleresimi v in vleresimet)
            {
                //sw.WriteLine(((Vleresimi)v).toString());
                sw.WriteLine(v);
            }
            sw.Flush();
            sw.Close();
        }

        public void CloseAll()
        {
            try
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }
            finally
            {
                Console.WriteLine("Files are closed!");
            }
        }
    }
}

