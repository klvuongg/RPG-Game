using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MininmumDamage {  get; set; }
        public int MaximumDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) : base(itemTypeID, name, price) 
        {
            MininmumDamage = minDamage;
            MaximumDamage = maxDamage;
        }
        
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MininmumDamage, MaximumDamage);
        }
    }
}
