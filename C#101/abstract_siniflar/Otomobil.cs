namespace abstract_siniflar
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            //Her a raç için direk 4 dönecek override etmeye ya da implement diyerek çağırmaya gerek kalmayacak.
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            //Renk olarak beyaz dönecek. Hiç ellenmezse beyaz döner ama istenirse ovirride edilerek ezilebilir ve renk değiştirilebilir.
            return Renk.Beyaz;
        }
        public abstract Marka HangiMarkaninAraci();
        // Aynı interfaceteki gibi her seferinde implmenet edilmesi ve gövdesinin yazılması gereken bir metod.
    }
}