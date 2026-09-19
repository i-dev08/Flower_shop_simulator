using UnityEngine;
using TMPro;
public class EarningUI : MonoBehaviour
{
    public PointsManager pointsManager;
    public TMP_Text earningText;

    void Update()
    {
        earningText.text = pointsManager.TotalPoints().ToString();
    }
}
