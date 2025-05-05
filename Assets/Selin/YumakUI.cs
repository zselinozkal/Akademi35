using UnityEngine;
using TMPro;  // ← REQUIRED for TextMeshPro

public class YumakUI : MonoBehaviour
{
    public TextMeshProUGUI countText;  // ← FIXED TYPE

    void Start()
    {
        UpdateCountText();
    }

    public void UpdateCountText()
    {
        countText.text = " " + CollectibleTracker.collectedCount;
    }
}
