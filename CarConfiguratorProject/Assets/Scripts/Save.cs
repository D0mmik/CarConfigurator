using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{   public WheelChanger wheelChanger;
    public ColorChanger colorChanger;
    public SpoilerChanger spoilerChanger;

    void Start()
    {
        LoadConfig();
        Application.targetFrameRate = 300;
    }

    public void SaveAs(string wheel,string color,string spoiler)
    {
        PlayerPrefs.SetInt(wheel, wheelChanger.currentWheel);
        PlayerPrefs.SetInt(color, colorChanger.currentColor);
        PlayerPrefs.SetInt(spoiler, spoilerChanger.currentSpoiler); 
    }
    public void LoadAs(string wheel, string color, string spoiler)
    {
        wheelChanger.dothis(PlayerPrefs.GetInt(wheel));
        colorChanger.dothis(PlayerPrefs.GetInt(color));
        spoilerChanger.dothis(PlayerPrefs.GetInt(spoiler));
    }
    private void OnDestroy()
    {
        SaveConfig();
    }
    private void SaveConfig()
    {
        SaveAs("currentWheel","currentColor", "currentSpoiler");  
    }
    private void LoadConfig()
    {
        LoadAs("currentWheel","currentColor", "currentSpoiler");
    }
    public void SaveConfig1()
    {
        SaveAs("currentWheel1","currentColor1", "currentSpoiler1");  
    }
    public void LoadConfig1()
    {         
        LoadAs("currentWheel1","currentColor1", "currentSpoiler1");
    }
    public void SaveConfig2()
    {
        SaveAs("currentWheel2","currentColor2", "currentSpoiler2");  
    }
    public void LoadConfig2()
    {
        LoadAs("currentWheel2","currentColor2", "currentSpoiler2");
    }
    public void SaveConfig3()
    {
        SaveAs("currentWheel3","currentColor3", "currentSpoiler3");   
    }
    public void loadConfig3()
    {
        LoadAs("currentWheel3","currentColor3", "currentSpoiler3");
    }
}
