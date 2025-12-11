using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Player : Character, ISpellCaster
    {
        private int _mana;
        private int _maxMana;
        private int _experience;
        private int _level;
        private IEquippable _equipableWeapon;
        private List<Item> _inventory;

        public int Mana
        {
            get => _mana;
            private set => _mana = Math.Max(0, Math.Min(value, _maxMana));
        }

        public int MaxMana
        {
            get => _maxMana;
            private set => _maxMana = value;
        }

        public int Experience
        {
            get => _experience;
            private set => _experience = value;
        }

        public int Level
        {
            get => _level;
            private set => _level = value;
        }

        public IReadOnlyList<Item> Inventory => _inventory.AsReadOnly();

        public Player(string name) : base(name, 100, 10)
        {

                _maxMana = 50;
                _mana = _maxMana;
                _level = 1;
            _experience = 0;
                _inventory = new List<Item>();
        }

        public override void Attack(Character target)
        {
           var rand = new Random();
            var baseDanage = Strength;

            if (_equipableWeapon != null && _equipableWeapon is Weapon weapon)
            {
                baseDanage= weapon.Danage;
            }

            var isCritical = rand.Next(180) < 28;
            var damage = isCritical ? baseDanage * 2 : baseDanage ;

            if (isCritical)
            {
                Console.WriteLine($"КРИТИЧНИЙ УДАР! {Name} завдає {damage} пошкоджень {target.Name}!");
            }
            else
            {

            }
        }

        public void CastSpell(Character target)
        {
            throw new NotImplementedException();
        }

        public void RestorMana(int amout)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}