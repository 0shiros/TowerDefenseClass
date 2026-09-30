
using System;

public class Health
{
    private float current;
    private float max;
    public event Action<float> Changed;
    public event Action Died;

    public void TakeDamage(float amount)
    {
        if ((current -= amount) < 0)
        {
            current = 0;
            Died?.Invoke();
        }
        else
        {
            Changed?.Invoke(current);
        }
    }

    public void Heal(float amount)
    {
        current += amount >= max ? current = max : current += amount;
        Changed?.Invoke(current);
    }
}