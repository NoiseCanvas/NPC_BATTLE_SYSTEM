using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDS_Factory
{
    public static CharacterData generateTestCD()
    {
        Debug.Log("Initializing Mock Character Data");
        CharacterData characterData = new CharacterData();
        characterData.world_position = new Vector3(0,0,0);

        return characterData;
    }

}
