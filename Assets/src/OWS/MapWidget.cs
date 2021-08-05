using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapWidget : MonoBehaviour
{
    public Vector3 mapPos = new Vector3();

    public void SetPosition(Vector3 value)
    {
        float tempX = Mathf.Repeat(value.x, 180.0f);
        float tempY = Mathf.Repeat(value.y, 360.0f);

        mapPos = new Vector3(tempX, tempY, 0);

        //Quaternion target = Quaternion.Euler(tempX, tempY, 0);

        //this.transform.rotation = target;
        Debug.Log(mapPos);

    }

    public Vector3 GetPosition()
    {
        return mapPos;
    }
}
