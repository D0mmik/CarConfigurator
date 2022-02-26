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
    private void OnDestroy()
    {
        SaveConfig();
        Debug.Log("saved");
    }
    private void SaveConfig()
    {
        PlayerPrefs.SetInt("currentWheel", wheelChanger.currentWheel);
        PlayerPrefs.SetInt("currentColor", colorChanger.currentColor);
        PlayerPrefs.SetInt("currentSpoiler", spoilerChanger.currentSpoiler);
    }
    private void LoadConfig()
    {
        wheelChanger.dothis(PlayerPrefs.GetInt("currentWheel"));
        colorChanger.dothis(PlayerPrefs.GetInt("currentColor"));
        spoilerChanger.dothis(PlayerPrefs.GetInt("currentSpoiler"));
    }
    public void SaveConfig1()
    {
        PlayerPrefs.SetInt("currentWheel1", wheelChanger.currentWheel);
        PlayerPrefs.SetInt("currentColor1", colorChanger.currentColor);
        PlayerPrefs.SetInt("currentSpoiler1", spoilerChanger.currentSpoiler);   
    }
    public void LoadConfig1()
    {
        wheelChanger.dothis(PlayerPrefs.GetInt("currentWheel1"));
        colorChanger.dothis(PlayerPrefs.GetInt("currentColor1"));
        spoilerChanger.dothis(PlayerPrefs.GetInt("currentSpoiler1"));
    }
    public void SaveConfig2()
    {
        PlayerPrefs.SetInt("currentWheel2", wheelChanger.currentWheel);
        PlayerPrefs.SetInt("currentColor2", colorChanger.currentColor);
        PlayerPrefs.SetInt("currentSpoiler2", spoilerChanger.currentSpoiler);  
    }
    public void LoadConfig2()
    {
        wheelChanger.dothis(PlayerPrefs.GetInt("currentWheel2"));
        colorChanger.dothis(PlayerPrefs.GetInt("currentColor2"));
        spoilerChanger.dothis(PlayerPrefs.GetInt("currentSpoiler2"));
    }
    public void SaveConfig3()
    {
        PlayerPrefs.SetInt("currentWheel3", wheelChanger.currentWheel);
        PlayerPrefs.SetInt("currentColor3", colorChanger.currentColor);
        PlayerPrefs.SetInt("currentSpoiler3", spoilerChanger.currentSpoiler); 
    }
    public void loadConfig3()
    {
        wheelChanger.dothis(PlayerPrefs.GetInt("currentWheel3"));
        colorChanger.dothis(PlayerPrefs.GetInt("currentColor3"));
        spoilerChanger.dothis(PlayerPrefs.GetInt("currentSpoiler3"));
    }
}
