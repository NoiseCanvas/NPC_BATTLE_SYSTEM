using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOverWorld
{
    public string[] getActions(CharacterData characterData);

    //Returns the subsection of the map that should be loaded into player view. 
    public Region getRegion(Vector3 location);


}
