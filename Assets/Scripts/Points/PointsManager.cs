using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private int points  = 0;

    public void AddPoints(int earning)
    {
        points += earning;
    }

    public int TotalPoints()
    {
        return points;
    }
}
