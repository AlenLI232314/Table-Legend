using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T>
{
    void HealDamage(T damageHealed);
    void TakeDamage(T damageTaken); //T will be int
    void OnDamage();
}

public interface IKillable
{
    void Kill();
    void OnKill();
}

public interface IBuyable<T>
{
    void Buy(T buyPrice);
    void Sell(T sellPrice);
}

public interface IRollable
{
    //prolly not needed, only dice are rollable
}
