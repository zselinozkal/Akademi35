using System.Collections.Generic;
using UnityEngine.UI;

public static class CollectibleTracker
{
    public static int collectedCount = 0;
    public static int healthCount = 3; // 3 kalp varsayılan
    public static int maxHealth = 3;   // Maksimum can sayısı

    public static void ResetHealth()
    {
        healthCount = maxHealth;
    }
}