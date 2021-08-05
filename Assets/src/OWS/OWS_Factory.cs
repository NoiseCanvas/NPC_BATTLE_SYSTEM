using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OWS_Factory
{
    public static IOverWorld createOverWorld()
    {
        return new MockOverWorld();
    }

}
