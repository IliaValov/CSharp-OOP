using DungeonsAndCodeWizards.Models.Items;
using System;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        public Bag.Bag Bag { get; set; }
        private Faction faction;

        public Character(string name, double health, double armor, double abilityPoints, Bag.Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.Health = health;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }

        public Faction Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public double BaseHealth
        {
            get { return baseHealth; }
            private set { baseHealth = value; }
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    health = 0;
                    IsAlive = false;
                }
                else if (value > BaseHealth)
                {
                    health = BaseHealth;
                }
                else
                {
                    health = value;
                }
            }
        }

        public double BaseArmor
        {
            get { return baseArmor; }
            set { baseArmor = value; }
        }

        public double Armor
        {
            get { return armor; }
            set
            {
                if (value < 0)
                {
                    armor = 0;
                }
                else if (value > BaseArmor)
                {
                    armor = BaseArmor;
                }
                else
                {
                    armor = value;
                }
            }
        }

        public double AbilityPoints
        {
            get { return abilityPoints; }
            set { abilityPoints = value; }

        }
        public double RestHealMultiplier { get; set; } = 0.2;

        public bool IsAlive = true;

        public void TakeDamage(double hitPoints)
        {
            if (this.IsAlive)
            {
                double currentArmor = Armor;
                if (this.Armor > 0)
                {
                    this.Armor -= hitPoints;
                    hitPoints -= currentArmor;
                }
                if (hitPoints > 0)
                {
                    Health -= hitPoints;
                    if (Health <= 0)
                    {
                        IsAlive = false;
                    }
                }
            }
        }

        public void Rest()
        {
            if (this.IsAlive)
            {
                Health += Health + (BaseHealth * 0.2);
            }
        }

        public void UseItem(Item item)
        {
            if (this.IsAlive)
            {
                switch (item.GetType().Name)
                {
                    case "ArmorRepairKit":
                        item.AffectCharacter(this);
                        break;
                    case "HealthPotion":
                        item.AffectCharacter(this);
                        break;
                    case "PoisonPotion":
                        item.AffectCharacter(this);
                        break;
                }
            }
        }

        public void UseItemOn(Item item, Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                switch (item.GetType().Name)
                {
                    case "ArmorRepairKit":
                        item.AffectCharacter(character);
                        break;
                    case "HealthPotion":
                        item.AffectCharacter(character);
                        break;
                    case "PoisonPotion":
                        item.AffectCharacter(character);
                        break;
                }
            }
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                character.ReceiveItem(item);
            }
        }

        public void ReceiveItem(Item item)
        {
            Bag.AddItem(item);
        }


    }
}

