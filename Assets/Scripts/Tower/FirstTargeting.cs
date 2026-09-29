
using UnityEngine;

[System.Serializable]
public class FirstTargeting : ITargeting
{
    public ITargetable Select(Enemy candidates, Vector3 origin, float range)
    {
        throw new System.NotImplementedException();
    }
}