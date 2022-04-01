namespace DungeonDio.src.Entities
{
    //Abstração
    public abstract class Hero
    {
        //Encapsulamento
        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }
        public int hp { get; set; }
        public int fullHP { get; set; }
        public int mp { get; set; }
        public int fullMP { get; set; }
        public string attackEquipment { get; set; }
        public string defenseEquipment { get; set; }
        
        public Hero(string name, int level, string heroType, int hp, int fullHP, int mp, int fullMP, string attackEquipment, string defenseEquipment)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.fullHP = fullHP;
            this.mp = mp;
            this.fullMP = fullMP;
            this.attackEquipment = attackEquipment;
            this.defenseEquipment = defenseEquipment; 
        }
    }
}