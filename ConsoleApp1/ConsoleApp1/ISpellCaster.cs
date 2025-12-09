namespace ConsoleApp1
{
    public interface ISpellCaster
    {
        int Mana { get; }

        void CastSpell(Character target);

        void RestorMana(int amout);

    }
}