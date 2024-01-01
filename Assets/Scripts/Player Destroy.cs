using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    public Score scorekeeper;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Danger")
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
            scorekeeper.addscore(20f);
        }
    }
}

