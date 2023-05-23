using static System.Console;

namespace Strategy
{
    public interface IWeaponBehavior
    {
        void UseWeapon();
    }

    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon() => WriteLine("б'ю сокирою");
    }

    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon() => WriteLine("б'ю ножем");
    }

    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon() => WriteLine("стріляю з лука");
    }

    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon() => WriteLine("б'ю мечем");
    }
}
