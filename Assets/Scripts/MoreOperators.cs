using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 1;
        int y=1;
        //bool result = x != y;
        string playerName = null;
        //bool result= playerName != null;
        int nextLevelXP = 18;
        int PlayerOneXP = 18;
        bool result = nextLevelXP <= PlayerOneXP;
        //Debug.Log(result);
        int coins =100;
        int totalLives = 13;
        int MaxLives = 10;
        bool IsPremium = true;
        bool shouldIncreaseLifeCount = coins >= 100 || totalLives < MaxLives || IsPremium ;
        bool shouldIncreaseDifficulty = totalLives > 5 && !IsPremium ;
        Debug.Log(shouldIncreaseDifficulty);
        
        string firstName = null;
        bool isUpperCase= firstName != null || firstName.ToUpper() =="Vegetarian";
        //Debug.Log(isUpperCase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
