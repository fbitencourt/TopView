using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(1, 4);
    }
}
