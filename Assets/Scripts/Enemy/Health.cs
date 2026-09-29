
using System;

public class Health
{
    private float current;
    private float max;
    public event Action<float> Changed;
    public event Action Died;

    public void TakeDamage(float amount)
    {
        
    }

    public void Heal(float amount)
    {
        
    }
}