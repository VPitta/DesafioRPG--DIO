using DesafioRPG.Entities;

namespace DesafioRPG.src.Entities
{
    public class Wizzard : Hero
    {
        public Wizzard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua Magia.";
        }   

        public string Attack( int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou uma magigia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia fraca com bonus de " + Bonus;
            }
        }    
    }
}