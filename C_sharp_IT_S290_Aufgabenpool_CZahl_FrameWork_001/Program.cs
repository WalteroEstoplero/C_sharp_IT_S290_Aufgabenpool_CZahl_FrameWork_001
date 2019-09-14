using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_IT_S290_Aufgabenpool_CZahl_FrameWork_001
{
    public class CGrundForm
        //abstract class CGrundForm
    {
        protected string bezeichnung;

        public CGrundForm()
        {
            this.bezeichnung = "";
        }

        public CGrundForm(string b)
        {
            this.bezeichnung = b;
        }

        //abstract public void SetPunkte(CPunkt a, CPunkt b, CPunkt c, CPunkt d);
    }

    public class CViereck : CGrundForm
    {
        private CPunkt [] punkt = new CPunkt[4];
 //       private CPunkt punkt2;
 //       private CPunkt punkt3;
 //       private CPunkt punkt4;

        public CViereck() : base()
        {
            Console.WriteLine("Standard-Konstruktor " + bezeichnung);
        }

        public CViereck(string t) : base(t)
        {
            Console.WriteLine("Parameter-Konstruktor " + bezeichnung);
            // Der Standard-Konstruktor wird danach NICHT aufgerufen !
        }

        // HIER 21:22

        public void SetPunkte(CPunkt p0, CPunkt p1, CPunkt p2, CPunkt p3)
        {
//            for (int i = 0; i < 4; i++)
//            {
                punkt[0] = p0;
                punkt[1] = p1;
                punkt[2] = p2;
                punkt[3] = p3;
//           }

        }

        public void Ausgabe()
        {
            Console.Write("Ausgabe CViereck Bezeichnung: ");
            Console.Write(bezeichnung + "; ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(punkt[i] + "; ");
//                Console.Write(punkt2 + "; ");
//                Console.Write(punkt3 + "; ");
//                Console.Write(punkt4 + "; ");
            }
            Console.WriteLine();
        }
    }

    public class CKreis: CGrundForm
    {
        private CPunkt punkt;
        private double radius;

        public CKreis() : base()
        {
            Console.WriteLine("Standard-Konstruktor " + bezeichnung);
        }

        public CKreis(string t) : base(t)
        {
            Console.WriteLine("Parameter-Konstruktor " + bezeichnung);
            // Der Standard-Konstruktor wird danach NICHT aufgerufen !
        }
        public void SetPunktRadius(CPunkt p, double r)
        {
            this.punkt = p;
            this.radius = r;
        }

        public void Ausgabe()
        {
            Console.Write("Ausgabe CKreis   Bezeichnung: ");
            Console.Write(bezeichnung + "  ; ");
            Console.Write(punkt + "; ");
            Console.Write("Radius: " + radius);
            Console.WriteLine();
        }
    }

    public struct CPunkt            // private geht nicht !
    {
        private int x;
        private int y;

        public CPunkt(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Struct <" + x + "|" + y + ">");
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }


        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        // override s.S. 95
        public override string ToString()
        {
            return ("<" + x.ToString() + "|" + y.ToString() + ">");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CViereck v = new CViereck("Viereck 1");
            CKreis k = new CKreis("Kreis 1");

            CPunkt [] p = new CPunkt[4];
            p[0] = new CPunkt(1, 3);
            p[1] = new CPunkt(4, 3);
            p[2] = new CPunkt(5, 8);
            p[3] = new CPunkt(1, 8);

            v.SetPunkte(p[0],p[1],p[2],p[3]);
            v.Ausgabe();

            double radius = 2.5;
            k.SetPunktRadius(p[0], radius);
            k.Ausgabe();


            Console.ReadLine();
        }
    }
}
