using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Podroz//: IStacja
    {
        protected Queue<Stacja> stacje;
        protected double koszt = 100;
        public Podroz()
        { 

        }
        virtual public double KosztPoRabacie()
        {
            return koszt * 0.9;
        }
        public void DodajStacje(string nazwaStacji,bool oplataKlimatyczna)
        {
            stacje.Enqueue(new Stacja());
            if (oplataKlimatyczna == true)
                koszt = koszt + 15;

        }
        public void UsunStacje()
        {
            stacje.Dequeue();
            
        }
        public void Powrot()
        {
            Stacja Kopia = stacje.Peek();
            stacje.Enqueue(Kopia);
        }
        //public void ZapiszPodroz();

    }
}
