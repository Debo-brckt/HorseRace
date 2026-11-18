using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform playeTransform;

    void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");
        // ne met rien après la virgule
    }
}
