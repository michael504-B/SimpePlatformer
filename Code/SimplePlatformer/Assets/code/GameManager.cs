using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public int totalcoins = ;
    public  int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        //coins = 0;

        if (instance == null)
        {
            instance = this;
        }
        
        if (instance != this)
            Destroy(gameObject);
        
        
        DontDestroyOnLoad(gameObject);
       
    }

    // Update is called once per frame
    void Update()
    {
        /*if(coins == totalcoins)
        {
            coins = 0;
            SceneManager.LoadScene(1);


        }
        */
        
       
    }
}
