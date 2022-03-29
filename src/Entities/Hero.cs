namespace POO.src.Entities
{
    public abstract class Hero
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public string Knight { get; set; }
        public int Hp { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Knight;
        }

    }
}