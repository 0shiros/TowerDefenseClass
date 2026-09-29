
using UnityEngine;

public class WaypointPath : MonoBehaviour, IPath
{
    private Transform[] waypoints;

    public float Length { get; }
    
    public IPathCursor CreateCursor()
    {
        throw new System.NotImplementedException();
    }
}
