using static System.Console;

namespace Strategy
{
    public abstract class Character
    {
        private IWeaponBehavior weaponBehavior;

        public abstract void Display();

        public void Fight()
        {
            if (weaponBehavior == null)
                WriteLine("б'ю кулаками");
            else
                weaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weapon) => this.weaponBehavior = weapon;
    }

    public class Queen : Character
    {
        public override void Display() => WriteLine("Queen");
    }

    public class King : Character
    {
        public override void Display() => WriteLine("King");
    }

    public class Trool : Character
    {
        public override void Display() => WriteLine("Trool");
    }

    public class Knight : Character
    {
        public override void Display() => WriteLine("Knight");
    }
}
