

[System.Serializable]
public class DamageEffect : IHitEffect
{
    public float amount;

    public void Apply(HitContext ctx)
    {
        throw new System.NotImplementedException();
    }
}
