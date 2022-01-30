namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string herotype)
        {
            this.Name = name;
            this.level = level;
            this.HeroType = herotype;
        }
    }
}