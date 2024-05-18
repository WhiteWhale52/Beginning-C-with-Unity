using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data;

public class MadLibs : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public bool statement=true;
    public string verb="kill";
    public string noun="woman";
    public string adjective="innocent";
    public int number=5;
    public string pluralnoun="circus performers";
    public float percent=85.5F;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();  
        textMeshPro.text =$"The is statement is{statement}. I did not {verb} the {noun}. I am not guilty. I am an {adjective} person. The act was performed by {number} wandering {pluralnoun}. I am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
