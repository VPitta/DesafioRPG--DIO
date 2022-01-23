using DesafioRPG.Entities;

namespace DesafioRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack( int AbsDano)
        {
            if(AbsDano > 100)
            {
                return this.Name + " Ao atacar absorveu de " + AbsDano + " dano.";
            }
            else
            {
                return this.Name + " infligiou um Dano sem critico " + AbsDano;
            }
    }
}
}