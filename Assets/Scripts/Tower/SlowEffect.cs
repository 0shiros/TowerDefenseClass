
[System.Serializable]
public class SlowEffect : IHitEffect
{
    public float factor;
    public float duration;
    
    public void Apply(HitContext ctx)
    {
        throw new System.NotImplementedException();
    }
}
