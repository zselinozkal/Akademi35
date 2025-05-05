using UnityEngine;
using TMPro;  // ← REQUIRED for TextMeshPro

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI countText;  // ← FIXED TYPE

    void Start()
    {
        UpdateCountText();
    }

    public void UpdateCountText()
    {
        countText.text = "Health: " + CollectibleTracker.healthCount;
    }
}
