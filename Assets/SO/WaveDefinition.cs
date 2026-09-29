
using System.Collections.Generic;
using UnityEngine;

public class WaveDefinition : ScriptableObject
{
    public List<SpawnGroup> groups;

    private void OnValidate()
    {
        
    }
}
