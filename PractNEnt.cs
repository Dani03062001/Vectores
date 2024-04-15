using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



    internal class PractNEnt
    {
        private int n; //CONSTRUCTOR
        public PractNEnt()
        {
            n = 0;
        }
        public void Cargar(int dato)
        {
            n = dato;
        }
        public int Descargar()
        {
            return n;
        }
        // EJERCICIO 1
        public double factorial()
        {
            double fac = 1;
            for (int contador = 1; contador <= n; contador++)
            {
                fac *= contador ;
            }
            return fac;
        }
        // EJERCICIO 2
        public bool VerifFibo()
        {
            int a, b, c, aux;
            a = -1; b = 1; c = 0;
            aux = n;
            while (c < aux)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (c == aux)
                return true;
            else return false;

        }
        // EJERCICIO 3
        public bool VerifExpo()
        {
            int contador=1;
            while(contador < n)
            {
                contador = contador * 2;
            }
            return contador == n;

        }
        // EJERCICIO 4
        public bool VerifMultotroNum(PractNEnt num)
        {
            int r;
            bool verifMult;
            r = n % num.n;
            if (r == 0)
            {
                verifMult = true;
            }
            else
            {
                verifMult = false;
            }
            return verifMult;
        }
        // EJERCICIO 5
        public bool Verifsubmul(PractNEnt num)
        {
            int r;
            bool verifMult;
            r = num.n % n;
            if (r == 0)
            {
                verifMult = true;
            }
            else
            {
                verifMult = false;
            }
            return verifMult;
        }
        // EJERCICIO 6
        public int cont_dig()
        {
            int aux = n;
            int contador = 0;
            while (aux > 0)
            {
                aux = aux / 10;
                contador=contador+1;
            }
            return contador;
        }
        public void unir2num(PractNEnt num)
        {
            int nn = 0;
            nn=n*(int)Math.Pow(10,num.cont_dig())+num.n;
            n = nn;
        }
        public void UnirnumMenmay(PractNEnt num)
        {
            PractNEnt nn;
            nn=new PractNEnt();
            nn.Cargar(n);
            if (n > num.n)
            {
                num.unir2num(nn);
                n=num.n;
            }
            else
            {
                nn.unir2num(num);
                n = nn.n;
            }
            
        }
        // EJERCICIO 7
        public void Unirtresnumeros(PractNEnt num2, PractNEnt num3)
        {
            PractNEnt num1;
            num1 = new PractNEnt();
            num1.Cargar(n);
            PractNEnt nn;
            nn=new PractNEnt();
            nn.Cargar(n);
            if(num1.n >= num2.n && num1.n >= num3.n)
            {
                num2.UnirnumMenmay(num3);   
                num2.unir2num(num1);
                n= num2.n;
            }
            else
            if(num2.n >= num1.n && num2.n >= num3.n)
            {
                num1.UnirnumMenmay(num3 );
                num1.unir2num(num2);
                n= num1.n;
            }
            else
                if (num3.n >= num1.n && num3.n >= num2.n)
            {
                num1.UnirnumMenmay(num2 );
                num1.unir2num(num3);
                n= num1.n;
            }
        }
        // EJERCICIO 8
        public void MayNum(PractNEnt num2,PractNEnt num3,PractNEnt may)
        {
            PractNEnt num1;
            num1= new PractNEnt();
            num1.Cargar(n);
            if (num1.n >= num2.n && num1.n >= num3.n)
            {
                may.n = 1;
            }
            else
            if (num2.n >= num1.n && num2.n >num3.n)
            {
                may.n = 2;
            }
            else
            if (num3.n > num1.n && num3.n >num2.n)
            {
                may.n = 3;
            }
        }
        // EJERCICIO 9
        public bool Verifdigigual()
        {
            int aux = n;
            int dig = 0;
            int aux2 = aux % 10;
            bool result=true;
            while ((aux > 0) && (result == true))
            {
                dig = aux % 10;
                aux = aux / 10;
                if (dig != aux2)
                {
                    result = false;
                }
                    
            } return result;
            
        }
        // EJERCICIO 10
        public bool VerifdigPar()
        {
            int aux = n;
            int dig = 0;
            bool result = true;
            while ((aux > 0) && (result == true))
            {
                dig = aux % 10;
                aux = aux / 10;
                if (dig % 2 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            return result;

        }
    }
