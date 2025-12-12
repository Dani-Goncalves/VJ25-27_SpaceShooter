using UnityEngine;

public class ScoreObjects : MonoBehaviour
{
    [SerializeField] private int score;

    void OnDestroy()
    {
        GameObject.Find("UIManager").GetComponent<UIManager>().AddScore(score);
    }
}
