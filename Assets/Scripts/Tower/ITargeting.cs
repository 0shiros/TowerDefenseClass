using UnityEngine;

public interface ITargeting
{
    public ITargetable Select(Enemy candidates, Vector3 origin, float range);
}