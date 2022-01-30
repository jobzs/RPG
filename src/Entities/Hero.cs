namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int level;
        public string HeroType;

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

        public override string ToString(){
            return this.Name + " " + this.level + " " + this.HeroType;
        }
        
         public Hero() {}

        public Hero(string name, int level, string herotype)
        {
            this.Name = name;
            this.level = level;
            this.HeroType = herotype;
        }
    }
        
    
}