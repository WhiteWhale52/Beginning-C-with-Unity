using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour

{
    private TextMeshProUGUI testMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        testMeshPro = GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayMessage()
    {
        int xp = 990;
        xp = xp + 10;
        int joyDivision = 5 / 2;
        string firstName = "Vegetarian";
        string lastName = "Zombie";
        string fullname = firstName + " " +lastName;
        int problem = 3 - 3 * 6 + 2;
        float conversion = (float)100;
        testMeshPro.text= $"{problem}";
    }
}
