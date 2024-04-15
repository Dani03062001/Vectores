using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NEnt
    {
        private int n; public NEnt() // Constructor
        {
            n = 0;
        }
        public void Cargar(int dato)
        {
            n = dato;
        }
        public void Cargar(int a, int b)
        {
            Random r;
            r = new Random(); n = r.Next(a, b + 1);
        }
        public int Descargar()
        {
            return n;
        }
        public bool Verifpar()
        {
            int r;
            bool b; r = n % 2;
            if (r == 0) b = true;
            else b = false;
            return b;
        }
        public Boolean VerifPri()
        {
            int c, i, r; c = 0;
            for (i = 1; i <= n; i++)
            {
                r = n % i; if (r == 0)
                    c++;
            }
            return (c == 2);
        }
        public void Inv()
        {
            int d, n1; n1 = 0;
            while (n > 0)
            {
                d = n % 10; n1 = n1 * 10 + d;
                n = n / 10;
            }
            n = n1;
        }
        public bool VerifCapi()
        {
            NEnt na; na = new NEnt();
            na.Cargar(n); na.Inv();
            return (n == na.n);
        }
        public bool Pert(int dig)
        {
            int aux, d; aux = n;
            do
            {
                d = n % 10;
                n = n / 10;
            } while (!((d == dig) || (n == 0)));
            n = aux; return (d == dig);
        }
    }

