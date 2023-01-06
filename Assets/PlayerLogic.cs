using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{

    public float PlayerSpeed = 2000.0f;
    ScoreLogic addToScore;
    // Start is called before the first frame update
    void Start()
    {
        HideCuser();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        var tempmouseposition = Input.mousePosition;

        tempmouseposition.z = transform.position.z - Camera.main.transform.position.z;

        tempmouseposition = Camera.main.ScreenToWorldPoint(tempmouseposition);

        transform.position = Vector3.MoveTowards(transform.position, tempmouseposition, 2000 * Time.deltaTime);
    }

    public void HideCuser()
    {
        Cursor.visible = false;
    }

    private void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if(tempCollision.gameObject.tag == "Collectible")
        {
            CallAddToScoreScript();

            Destroy(tempCollision.gameObject);

        }

        if(tempCollision.gameObject.tag == "BadCollectible")
        {
            ResetGame();
        }
    }

    public void CallAddToScoreScript()
    {
        ScoreLogic.instance.AddtoScore();
    }

    void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
