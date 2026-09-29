
using System.Collections.Generic;
using UnityEngine;

public struct HitContext
{
    public ITargetable target;
    public Vector2 impactPoint;
    public IReadOnlyList<ITargetable> targets;
}
