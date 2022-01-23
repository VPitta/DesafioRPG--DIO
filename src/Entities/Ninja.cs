using DesafioRPG.Entities;

namespace DesafioRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua Furtividade.";
        }

        public string Attack( int DanoCosta)
        {
            if(DanoCosta > 10)
            {
                return this.Name + " Infligiu um dano critico pelas costas de " + DanoCosta;
            }
            else
            {
                return this.Name + " Não Inflingiu Dano Aumentado pelas Costas " + DanoCosta;
            }    
        }
}
}