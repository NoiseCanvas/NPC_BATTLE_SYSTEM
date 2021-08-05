using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockOverWorld : IOverWorld
{

    public MockOverWorld()
    {
        Debug.Log("Initializing Mock OverWorld");
    }

    public string[] getActions(CharacterData characterData)
    {
        return new string[] {"sleep","fight"};
    }

    public Region getRegion(Vector3 location)
    {
        return Region.GATES_OF_ETERNITY;
    }
}
