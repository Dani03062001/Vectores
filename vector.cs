using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{ 
    internal class vector //CONSTRUCTOR
    {
        const int MAX = 101;
        private int[] v;
        private int n;

        public vector()
        {
            v = new int[MAX];
            n= 0;
        }
        public void Cargar(int n1, int dato1, int dato2)
        {
            int i;
            Random r;
            r= new Random();
            n = n1;
            for(i = 1; i <= n; i++)
            {
                v[i] = r.Next(dato1, dato2 + 1);
            }
        }
        public void Cargar (int dato)
        {
            n++;
            v[n]= dato;
        }
        public String Descargar()
        {
            string s;
            int i;
            s = "";
            for(i = 1; i <= n; i++)
            {
                s = s + v[i]+ "|";
            }
            return s;
        }
        public void CargarFib(int n1, int a, int b)
        {
            int i, c;
            n = n1;
            for (i = 1; i <= n; ++i)
            {
                c = a + b;a=b;b = c;
                v[i] = c;
            }
        }
        public int Acum()
        {
            int i, s;
            s = 0;
            for(i = 1; i <= n; i++)
            {
                s = s + v[i];
            }
            return s;
        }
        public double Media()
        {
          return this.Acum() / (double)n;  
        }
        public double DesvMed()
        {
            double s, m;
            int i;
            s = 0;
            m = Media();
            for(i=1; i <= n; i++)
            {
                s = s + Math.Abs(v[i]-m);
            }
            return s/n;
        }
        public int FrecEle(int ele)
        {
            int i, fr;
            fr = 0;
            for (i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                    fr++;
            }
            return fr;
        }
        public int FrecPrim()
        {
            int i, fr;
            NEnt nu;
            nu = new NEnt();
            fr = 0;
            for(i=1; i <= n; i++)
            {
                nu.Cargar(v[i]);
                if (nu.VerifPri() == true)
                    fr++;
            }
            return fr;
        }
        public int FrecNPrim()
        {
            return n - FrecPrim();
        }
        public int Maximo()
        {
            int i, may;
            may = v[1];
            for (i=2; i <= n; i++)
            {
                if (v[i]>may)
                    may = v[i];
            }
            return may;
        }
        public void SelecApRep(ref vector ap, ref vector nap)
        {
            int i;
            ap.n = 0;
            nap.n=0;
            for( i=1; i<=n; i++)
            {
                if (v[i] > 50)
                    ap.Cargar(v[i]);
                else
                    nap.Cargar(v[i]);
            }    
        }
        public bool BuscSec(int ele)
        {
            int i;
            bool b;
            b=false;
            i = 1;
            while ((i<=n) && (b == false))
            {
                if (v[i] == ele)
                {
                    b = true;
                }
                else 
                {
                    i++;
                }
            }
            return b;
        }
        public bool BuscSecPrim()
        {
            int i;
            bool b;
            NEnt nu= new NEnt();
            b = false;
            i = 1;
            while ((i <= n) && (b == false))
            {
                nu.Cargar(v[i]);
                if (nu.VerifPri())
                {
                    b = true;
                }
                else
                {
                    i++;
                }
            }
            return b;
        }
        public int BuscSecP(int ele) 
        {
            int i, b;
            b = 0;
            i = 1;
            while ((i <= n) && (b==0)) 
            {
                if (v[i] == ele)
                {
                    b = i;
                }
                else
                {
                    i++;
                }
            }
            return b;
        }
        public void CargarSRep(int n1, int a, int b)
        {
            int ele;
            Random r;
            r=new Random();
            n = 0;
            do
            {
                ele = r.Next(a,b+1);
                if (BuscSec(ele)==false)
                {
                    Cargar(ele);
                }
            }
            while (!(n==n1));
        }
        public bool VerifOrdDesc()
        {
            int i;
            bool b;
            b = true;
            i = 1;
            while ((i <= n)&&(b==true)) 
            {
                if (!(v[i] >= v[i + 1]))
                {
                    b=false;
                }
                else 
                { 
                b=true;
                }
            }
            return b;   
        }
        public bool VerifOrdDescConRigor(int r)
        {
            int i;
            bool b;
            b = true;
            i = n;
            while ((i >= 2) && (b == true))
            {
                if (!(v[i] >= v[i - 1]+r))
                {
                    b = false;
                }
                else
                {
                    i--;
                }
            }
            return b;
        }
        public bool VerifIgual()
        {
            int i;
            bool b;
            b = true;
            i = 2;
            while ((i <= n) && (b == true))
            {
                if (!(v[i] == v[1]))
                {
                    b=false;
                }
                else
                {
                    i++;
                }
            }
            return b;
        }
        public void Inter(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void OrdInter()
        {
            int p, d;
            for(p = 1; p <= n - 1; p++)
            {
                for (d = p+1; d <= n ; d++)
                    if (v[d] < v[p])
                        Inter(p, d);
            }
        }
        public void OrdInter1()
        {
            int p, d;
            for (p = 1; p <= n - 1; p++)
            {
                for (d = n; d >= p+1; d--)
                    if (v[d] < v[p])
                        Inter(d, p);
            }
        }
        public void OrdInter2()
        {
            int p, d;
            for (p = n; p >= 2 ; p--)
            {
                for (d = p-1; d >= 1; d--)
                    if (v[d] > v[p])
                        Inter(d, p);
            }
        }
        public void OrdInter3()
        {
            int p, d;
            p = n;
            while (p >= 2)
            {
                for(d = p-1;d>= 1; d--)
                    if (v[d] > v[p])
                        Inter(d,p);
                p--;    
            } 
        }
        public void OrdInterDesc()
        {
            int p, d;
            p = n;
            while (p >= 2)
            {
                for (d = p - 1; d >= 1; d--)
                    if (v[d] < v[p])
                        Inter(d, p);
                p--;
            }
        }
        public void OrdSelecc()
        {
            int p,d,s;
            for (p = 1; p <= n - 1; p++)
            {
                s = p;
                for (d = p + 1; d <= n; d++)
                    if (v[d] < v[s])
                        s = d;
                if (s != p)
                {
                    Inter(s, p);
                }
            }

        }
        public void OrdCont(ref vector r)
        {
            vector c = new vector();
            int p, d, i;
            c.Cargar(n, 1, 1);
            for (p = 1; p <= n - 1; p++)
                for (d = p + 1; d <= n; d++)
                    if (v[d] < v[p])
                        c.v[p]++;
                    else
                        c.v[d]++;
            for
            (i = 1; i <= n; i++)
                r.v[c.v[i]] = v[i];
            r.n = n;
        }
        public void OrdBurb()
        {
            int t, d;
            for t=n;t>=2；t--）
            for (d = 1; d<= t - 1; d++) 
                if (v[d] › v[d + 1]) 
                inter (d, d+1);
        }
        public void OrdBurbInv()
        {
            int t, d;
            for (t = 1; t <= n-1; t++)
            for (d = n; d ›= t + 1; d--)
                 if (v[d] < v[d -1])
                     Inter(d, d - 1);
        }
    }

}
