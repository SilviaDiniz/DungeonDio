namespace DungeonDio.src.Entities
{
    //Herança
    public class Ninja : Hero
    {
        //Encapsulamento
        public string shuriken { get; set; }

        public Ninja(string name, int level, string heroType, int hp, int fullHP, int mp, int fullMP, string attackEquipment, string defenseEquipment):
                base(name, level, heroType, hp, fullHP, mp, fullMP, attackEquipment, defenseEquipment)
        {
            this.shuriken = "Shuriken";
        }

        public string myAttack()
        {
            return this.attackEquipment == this.attackEquipment ? $"{this.name} atacou com {this.attackEquipment}!" : $"{this.name} atacou com Shuriken!";
        }

        public string myDefense()
        {
            return $"{this.name} se defendeu usando {this.defenseEquipment}!";
        }

        //Polimorfismo
        public override string ToString()
        {
            return name + "\n"
                  + " Lv  " + level + "  " + heroType + "\n"
                  + " HP  " + hp + " /  " + fullHP + "\n"
                  + " MP  " + mp + " /  " + fullMP + "\n\n"
                  + "Equipamento de ataque:  " + attackEquipment + ".\n"
                  + "Equipamento Defesa:  " + defenseEquipment + ".\n";
        }        
    }
}