using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyVariables : MonoBehaviour
{
    // Just a scartchpad for playing with variables
    public string firstName;
    public string lastName;
    

    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName} {lastName}";
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++) { 
        
        }
    }
}
