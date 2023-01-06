using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImerToDelete : MonoBehaviour
{
    public float TimeForItemToByeBye;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TimeForItemToByeBye -= Time.deltaTime;

        if(TimeForItemToByeBye <= 0)
        {
            Destroy(gameObject);
        }
    }
}
