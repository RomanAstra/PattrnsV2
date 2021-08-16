namespace Asteroids.First
{
    interface IWeaponFactory
    {
        IWeapon CreateWeapon<IWeapon>();
    }
}
