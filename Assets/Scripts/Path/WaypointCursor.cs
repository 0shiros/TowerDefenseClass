
using UnityEngine;

public class WaypointCursor : IPathCursor
{
    public float RemainingDistance { get; }
    public bool Finished { get; }
    private float traveled;
    
    public Vector2 Advance(float distance)
    {
        throw new System.NotImplementedException();
    }
}
