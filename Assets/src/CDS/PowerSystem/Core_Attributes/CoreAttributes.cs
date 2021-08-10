using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreAttributes : Power
{
    int level = 0;
    int exp = 0;
    int health = 0;
    int stamina = 0;
    int focus = 0;
    int aura = 0;


    public CoreAttributes() : base("Core Attributes", "How you measure up", PowerType.Core_Attributes)
    {

    }

}
