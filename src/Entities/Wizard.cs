namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        
         public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.level = level;
            this.HeroType = herotype;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus) {

            if(Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else {
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }

            
        }

    }
}