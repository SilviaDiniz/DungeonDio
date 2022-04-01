namespace DungeonDio.src.Entities
{
    //Herança
    public class Wizard : Hero
    {
        public int attackForce { get; set; }

        public Wizard(string name, int level, string heroType, int hp, int fullHP, int mp, int fullMP, string attackEquipment, string defenseEquipment, int attackForce):
                 base(name, level, heroType, hp, fullHP, mp, fullMP, attackEquipment, defenseEquipment)
        {
            this.attackForce = attackForce;
        }

        public string myAttack()
        {
            return this.attackForce > 6 ? $"{this.name} atacou com {this.attackEquipment} de bonus {this.attackForce}!" : $"{this.name} atacou com {this.attackEquipment} muito fraco!";
        }

        public string myDefense()
        {
            return ($"{this.name} se defendeu com {this.defenseEquipment}!");
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