using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMY_TAG = "Enemy";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            hitCount++;
        }

        hitCount++;
        if (hitCount >= 5)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
    }
}
