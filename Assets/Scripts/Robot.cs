using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public int standardHealth = 100;
    public int standardBaseDamage { get; private set; }
    public int standardDodgeCapability = 10;
    public int standardArmor = 20;
    // Start is called before the first frame update
    void Start()
    {
        standardBaseDamage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Attack()
    {

    }

    public virtual void Dodge()
    {

    }
}
