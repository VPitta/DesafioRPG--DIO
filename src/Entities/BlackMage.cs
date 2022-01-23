using DesafioRPG.Entities;

namespace DesafioRPG.src.Entities
{
    public class BlackMage : Hero
    {
        public BlackMage(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua Magia Negra.";
        } 

        public string Attack( int Queimadura)
        {
            if(Queimadura > 30)
            {
                return this.Name + " Infligiu um dano de queimadura de  " + Queimadura + " durante 15seg.";
            }
            else
            {
                return this.Name + " Não Inflingiu Dano de queimadura " + Queimadura;
            }    
        }




        
    }
}