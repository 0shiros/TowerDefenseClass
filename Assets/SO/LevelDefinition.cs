
using UnityEngine;

public class LevelDefinition : ScriptableObject
{
    public string displayName;
    public string sceneName;
    public int startGold;
    public int startLives;
    public TowerDefinition[] availableTowers;
    public WaveDefinition[] waves;
}
