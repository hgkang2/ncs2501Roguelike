using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellObject : MonoBehaviour
{
    protected Vector2Int m_cell;
    public virtual void Init(Vector2Int cell)
    {
        m_cell = cell;
    }
    public virtual void PlayerEntered()
    {
    }
    public virtual bool PlayerWantsToEnter()
    {
        return true;
    }
}