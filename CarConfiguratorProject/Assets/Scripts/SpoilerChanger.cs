using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoilerChanger : MonoBehaviour
{
    public GameObject[] spolers;
    public Buttons Buttons;
    public GameObject currentclone;
    public int currentSpoiler;

    void Start()
    {

        for(int i = 0; i < spolers.Length; i++)
        {   
            var SpoilerButtonClone = Instantiate(Buttons, transform).GetComponent<Buttons>();
            SpoilerButtonClone.ButtonInt = i;
            SpoilerButtonClone.Name.text = ($"SPOILER {SpoilerButtonClone.ButtonInt}");  
            SpoilerButtonClone.Button.onClick.AddListener(()=>dothis(SpoilerButtonClone.ButtonInt));        
        }
    }
    public void dothis(int number)
    {  Destroy(currentclone);
       currentSpoiler = number;
       currentclone = Instantiate(spolers[number]);
    }
}
