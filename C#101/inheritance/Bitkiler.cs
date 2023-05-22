using System;

namespace inheritance
{
    public class Bitkiler : Canlilar
    {
        public Bitkiler()
        {
            /*
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            Bence buradan çağırılmaları daha doğruydu.
            */
        }
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak(); //bitkiler baseinden gelir.
            base.Beslenme(); // base in base i olan canlılar base inden gelir.
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
