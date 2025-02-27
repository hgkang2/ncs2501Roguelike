using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObject : CellObject
{
    public override void playerEntered()
    {
        Destroy(gameObject);
        Debug.Log("Food increased");
    }
}
