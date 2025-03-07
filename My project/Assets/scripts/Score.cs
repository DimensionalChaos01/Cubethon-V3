using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext;

    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
