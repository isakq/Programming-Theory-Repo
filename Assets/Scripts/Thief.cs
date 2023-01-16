using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Robot
{
    public int thiefHealth;
    public int thiefBaseDamage;
    public int thiefDodgeCApability;
    public int thiefArmor;
    private void Start()
    {
        thiefHealth = 75;
        thiefBaseDamage = baseDamage;
        thiefDodgeCApability = 40;
        thiefArmor = 0;
    }

    public override void Attack()
    {

    }

    public override void Dodge()
    {
        
    }
}
