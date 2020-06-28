using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LanguageDataName",menuName ="ScriptableObjects/LanguageData")]
public class LanguageData : ScriptableObject
{
    //identifiers can be used whenever we need them
    public string langaugeName;
    public int ID;

    //samples variables will be used in this sample
    [Header("Sample")]
    public string title = "Title";
    public string play = "Play";

    //below texts are for reference i used it in my latest game.
    [Header("Settings")]
    public string settings = "Settings";
    public string themeSelecion = "Color Theme";
    public string themeOption = "Theme";
    public string autoTheme = "Auto Color";
    public string sound = "Sound";
    public string language = "Langauge";
    public string controls = "Controls";

    [Header("Game UI")]
    public string level = "Level";
    public string gameOver = "Game Over!";
    public string completed  = "Completed!";
    public string paused = "Leave?";
    public string score = "Score";


    [Header("Rate App")]
    public string rateTitle = "Rate This App";
    public string rateMessage = "Please take a moment to rate this App";
    public string rateYes = "Rate Now";
    public string rateLater = "Later";
    public string rateNo = "No, Thanks";

    [Header("Share")]
    public string shareRequest = "Share this Game";
    public string shareRequestMessage = "Would you like to share?";
    public string shareYes = "Yes";  
    public string shareMessage = "https://www.google.com/";



}
