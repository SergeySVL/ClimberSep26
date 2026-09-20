using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    public float min_X = -2.6f, max_X = 2.6f, min_Y = -5.6f;

    private bool out_of_bounds;

    void Update()
    {
        CheckBounds();        
    }

    void CheckBounds()
    {
        Vector2 temp = transform.position;

        if (temp.x > max_X) {
            temp.x = max_X;
        }

        if (temp.x < min_X) {
            temp.x = min_X;
        }

        transform.position = temp;

        if (temp.y <= min_Y) {
            if(!out_of_bounds)
            {
                out_of_bounds = true;
                SoundManager.instance.DeathSound();
                GameManager.instance.RestartGame();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "TopSpike")
        {
            // transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }

}
