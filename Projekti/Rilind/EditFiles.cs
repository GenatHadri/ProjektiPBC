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
        StreamReader sr;
        StreamWriter sw;
        List<Profesori> profesoret = new List<Profesori>();
        List<Lenda> lendet = new List<Lenda>();
        List<Studenti> studentet = new List<Studenti>();
        List<Tema> temat = new List<Tema>();
        List<Komisioni> komisionet = new List<Komisioni>();
        List<Kerkesa> kerkesat = new List<Kerkesa>();
        List<Shqyretimi> shqyretimet = new List<Shqyretimi>();
        List<Takimet> takimet = new List<Takimet>();
        List<Vleresimi> vleresimet = new List<Vleresimi>();

        public StreamReader Sr { get => sr; set => sr = value; }
        public StreamWriter Sw { get => sw; set => sw = value; }

        public void Container()
        {
            Lenda l1 = new Lenda("Matematike", 5, true);
            Lenda l2 = new Lenda("Algoritme", 5, true);
            Lenda l3 = new Lenda("Databaze", 5, true);
            Lenda l4 = new Lenda("TZP", 5, true);
            Lenda l5 = new Lenda("WEB", 5, true);
            Lenda l6 = new Lenda("Arkitekture e kompjuterave", 5, true);
            Lenda l7 = new Lenda("SHK1", 5, true);
            Lenda l8 = new Lenda("SHK2", 5, true);
            Lenda l9 = new Lenda("Hyrje ne WEB", 5, true);
            Lenda l10 = new Lenda("BTI", 5, true);
            Lenda l11 = new Lenda("BIEE", 5, true);
            Lenda l12 = new Lenda("Sisteme te sinjaleve", 5, true);
            lendet.Add(l1);
            lendet.Add(l2);
            lendet.Add(l3);
            lendet.Add(l4);
            lendet.Add(l5);
            lendet.Add(l6);
            lendet.Add(l7);
            lendet.Add(l8);
            lendet.Add(l9);
            lendet.Add(l10);
            lendet.Add(l11);
            lendet.Add(l12);

            Profesori p1 = new Profesori(10, "Blerim", "Gashi", "bg@gmail.com", "+38312345678", "Master");
            Profesori p2 = new Profesori(10, "Xhelal", "Jashari", "xj@gmail.com", "+38312345678", "Master");
            Profesori p3 = new Profesori(10, "Edmond", "Jahjaga", "ej@gmail.com", "+38312345678", "Master");
            Profesori p4 = new Profesori(10, "Betim", "Gashi", "betim.g@gmail.com", "+38312345678", "Master");
            Profesori p5 = new Profesori(10, "Arber", "Kadriu", "ak@gmail.com", "+38312345678", "Master");
            Profesori p6 = new Profesori(10, "Artan", "Berisha", "ab@gmail.com", "+38312345678", "Master");
            Profesori p7 = new Profesori(10, "Vesa", "Morina", "vm@gmail.com", "+38312345678", "Master");
            Profesori p8 = new Profesori(10, "Ermir", "Rugova", "er@gmail.com", "+38312345678", "Master");
            profesoret.Add(p1);
            profesoret.Add(p2);
            profesoret.Add(p3);
            profesoret.Add(p4);
            profesoret.Add(p5);
            profesoret.Add(p6);
            profesoret.Add(p7);
            profesoret.Add(p8);

            Studenti s1 = new Studenti(20, "Genat", "Hadri", "gh@gmail.com", "CSE");
            Studenti s2 = new Studenti(21, "Rilind", "Bejta", "rb@gmail.com", "CSE");
            Studenti s3 = new Studenti(22, "Alban", "Selmanaj", "as@gmail.com", "CSE");
            Studenti s4 = new Studenti(23, "Valmire", "Gashi", "vg@gmail.com", "CSE");
            Studenti s5 = new Studenti(24, "Erion", "Bytyqi", "eb@gmail.com", "CSE");
            Studenti s6 = new Studenti(25, "Qendrim", "Sadriaj", "qs@gmail.com", "CSE");
            Studenti s7 = new Studenti(26, "Nderim", "Qerimi", "nq@gmail.com", "CSE");
            Studenti s8 = new Studenti(27, "Blend", "Zhegrova", "bz@gmail.com", "CSE");
            Studenti s9 = new Studenti(28, "Adhurim", "Krasniqi", "ak@gmail.com", "CSE");
            Studenti s10 = new Studenti(29, "Fidan", "Hashani", "hs@gmail.com", "CSE");
            Studenti s11 = new Studenti(30, "Lir", "Ballata", "lb@gmail.com", "CSE");
            Studenti s12 = new Studenti(31, "Endrit", "Tafilaj", "ef@gmail.com", "CSE");
            Studenti s13 = new Studenti(32, "Leonard", "Zaberxha", "lz@gmail.com", "CSE");
            Studenti s14 = new Studenti(33, "Serafina", "Berbatovci", "sb@gmail.com", "CSE");
            Studenti s15 = new Studenti(34, "Florentine", "Hamiti", "fh@gmail.com", "CSE");
            Studenti s16 = new Studenti(35, "Bleona", "Curri", "bc@gmail.com", "CSE");
            Studenti s17 = new Studenti(36, "Urata", "Sadiku", "us@gmail.com", "CSE");
            Studenti s18 = new Studenti(37, "Arjeta", "Zabeli", "az@gmail.com", "CSE");
            studentet.Add(s1);
            studentet.Add(s2);
            studentet.Add(s3);
            studentet.Add(s4);
            studentet.Add(s5);
            studentet.Add(s6);
            studentet.Add(s7);
            studentet.Add(s8);
            studentet.Add(s9);
            studentet.Add(s10);
            studentet.Add(s11);
            studentet.Add(s12);
            studentet.Add(s13);
            studentet.Add(s14);
            studentet.Add(s15);
            studentet.Add(s16);
            studentet.Add(s17);
            studentet.Add(s18);

            Tema t1 = new Tema("Funksionet Aritmetike");
            Tema t2 = new Tema("Ndertimi i Web Aplikacionit per shitje online");
            Tema t3 = new Tema("Data Analysis");
            Tema t4 = new Tema("Perdorimi i teknologjis me matematik");
            Tema t5 = new Tema("Aplikimi i AI ne biznes");
            Tema t6 = new Tema("Aplikimi i teknologjive HTML");
            Tema t7 = new Tema("Analiza e sigurise ne rrjete kompjuterike");
            Tema t8 = new Tema("Monitorimi i shendetit personal");
            temat.Add(t1);
            temat.Add(t2);
            temat.Add(t3);
            temat.Add(t4);
            temat.Add(t5);
            temat.Add(t6);
            temat.Add(t7);
            temat.Add(t8);

            Kerkesa k1 = new Kerkesa(p1, s1, t1);
            Kerkesa k2 = new Kerkesa(p2, s2, t2);
            Kerkesa k3 = new Kerkesa(p3, s3, t4);
            Kerkesa k4 = new Kerkesa(p4, s4, t2);
            Kerkesa k5 = new Kerkesa(p5, s5, t3);
            Kerkesa k6 = new Kerkesa(p6, s6, t7);
            Kerkesa k7 = new Kerkesa(p7, s7, t8);
            Kerkesa k8 = new Kerkesa(p8, s8, t4);
            Kerkesa k9 = new Kerkesa(p2, s9, t6);
            Kerkesa k10 = new Kerkesa(p1, s11, t5);
            Kerkesa k11 = new Kerkesa(p5, s15, t1);
            kerkesat.Add(k1);
            kerkesat.Add(k2);
            kerkesat.Add(k3);
            kerkesat.Add(k4);
            kerkesat.Add(k5);
            kerkesat.Add(k6);
            kerkesat.Add(k7);
            kerkesat.Add(k8);
            kerkesat.Add(k9);
            kerkesat.Add(k10);
            kerkesat.Add(k11);

            Komisioni komisioni1 = new Komisioni(profesoret);
            Komisioni komisioni2 = new Komisioni(profesoret);
            Komisioni komisioni3 = new Komisioni(profesoret);
            Komisioni komisioni4 = new Komisioni(profesoret);
            Komisioni komisioni5 = new Komisioni(profesoret);
            Komisioni komisioni6 = new Komisioni(profesoret);
            Komisioni komisioni7 = new Komisioni(profesoret);
            Komisioni komisioni8 = new Komisioni(profesoret);
            Komisioni komisioni9 = new Komisioni(profesoret);
            Komisioni komisioni10 = new Komisioni(profesoret);
            Komisioni komisioni11 = new Komisioni(profesoret);
            komisionet.Add(komisioni1);
            komisionet.Add(komisioni2);
            komisionet.Add(komisioni3);
            komisionet.Add(komisioni4);
            komisionet.Add(komisioni5);
            komisionet.Add(komisioni6);
            komisionet.Add(komisioni7);
            komisionet.Add(komisioni8);
            komisionet.Add(komisioni9);
            komisionet.Add(komisioni10);
            komisionet.Add(komisioni11);

            Shqyretimi shqyretimi1 = new Shqyretimi(komisioni1, k1, true);
            Shqyretimi shqyretimi2 = new Shqyretimi(komisioni3, k2, false);
            Shqyretimi shqyretimi3 = new Shqyretimi(komisioni2, k3, false);
            Shqyretimi shqyretimi4 = new Shqyretimi(komisioni4, k4, true);
            Shqyretimi shqyretimi5 = new Shqyretimi(komisioni5, k5, true);
            Shqyretimi shqyretimi6 = new Shqyretimi(komisioni6, k6, true);
            Shqyretimi shqyretimi7 = new Shqyretimi(komisioni7, k7, false);
            Shqyretimi shqyretimi8 = new Shqyretimi(komisioni11, k11, false);
            Shqyretimi shqyretimi9 = new Shqyretimi(komisioni8, k8, true);
            Shqyretimi shqyretimi10 = new Shqyretimi(komisioni9, k9, false);
            Shqyretimi shqyretimi11 = new Shqyretimi(komisioni10, k10, true);
            shqyretimet.Add(shqyretimi1);
            shqyretimet.Add(shqyretimi2);
            shqyretimet.Add(shqyretimi3);
            shqyretimet.Add(shqyretimi4);
            shqyretimet.Add(shqyretimi5);
            shqyretimet.Add(shqyretimi6);
            shqyretimet.Add(shqyretimi7);
            shqyretimet.Add(shqyretimi8);
            shqyretimet.Add(shqyretimi9);
            shqyretimet.Add(shqyretimi10);
            shqyretimet.Add(shqyretimi11);

            Takimet takimi1 = new Takimet(k1, 12);
            Takimet takimi2 = new Takimet(k2, 12);
            Takimet takimi3 = new Takimet(k4, 12);
            Takimet takimi4 = new Takimet(k1, 9);
            Takimet takimi5 = new Takimet(k2, 8);
            Takimet takimi6 = new Takimet(k4, 5);
            takimet.Add(takimi1);
            takimet.Add(takimi2);
            takimet.Add(takimi3);
            takimet.Add(takimi4);
            takimet.Add(takimi5);
            takimet.Add(takimi6);

            Vleresimi v1 = new Vleresimi(komisioni9, k1, 10);
            Vleresimi v2 = new Vleresimi(komisioni3, k5, 8);
            Vleresimi v3 = new Vleresimi(komisioni2, k2, 6);
            Vleresimi v4 = new Vleresimi(komisioni5, k6, 7);
            vleresimet.Add(v1);
            vleresimet.Add(v2);
            vleresimet.Add(v3);
            vleresimet.Add(v4);
        }

        public void ShkruajLendet()
        {
            sw.Close();
            sw = new StreamWriter(@"C:\Users\PC\Desktop\editFiles\Lenda.txt");
            foreach (Lenda l in lendet)
            {
                sw.WriteLine(((Lenda)l).toString() + " \n");
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
                Console.WriteLine("Files are closed");
            }
        }
    }
}

