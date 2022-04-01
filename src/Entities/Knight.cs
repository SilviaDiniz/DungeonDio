namespace DungeonDio.src.Entities
{
    //Herança
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hp, int fullHP, int mp, int fullMP, string attackEquipment, string defenseEquipment):
                 base(name, level, heroType, hp, fullHP, mp, fullMP, attackEquipment, defenseEquipment)
        { 
        }

        public string myAttack()
        {
            return $"{this.name} atacou usando {this.attackEquipment}!";
        }

        public string myDefense()
        {
            return $"{this.name} defendeu usando {this.defenseEquipment}!";
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