using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public Text scoreboard;

    // Update is called once per frame
    void Update()
    {
        scoreboard.text = playerPosition.position.z.ToString();
    }
}
