using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollected : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        GameManager.instance.coins += 1;
        //GameManager.Coins++;
        Debug.Log(gameObject.name);
        SceneManager.LoadScene(1);
    }
}
