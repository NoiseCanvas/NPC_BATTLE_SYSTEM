using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDS_Test : MonoBehaviour
{
    private CharacterData player1;
    private CharacterData player2;

    void Start()
    {
        player1 = CDS_Factory.generateTestCD();
        player2 = CDS_Factory.generateTestCD();

        Mentality ment = (Mentality)player1.powerSystem.getPowerByName("");
    }
}
