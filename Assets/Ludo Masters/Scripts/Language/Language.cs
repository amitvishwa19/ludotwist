using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{

    public Locale[] locale;
    public Text vsComputer;
    public Text localMultiplayer;
    public Text playOnline;
    public Text playWithFriend;
    public Text gameAudioVolume;
    public Text languageText;
    public Text terms;
    public Text privacy;
    public Text version;
    public Text deviceid;

    void Start()
    {
        if (PlayerPrefs.HasKey("lang")) {
            int index = PlayerPrefs.GetInt("lang");
            CurrentLanguage(index);
        }
    }

    public void CurrentLanguage(int index) {
        vsComputer.text = locale[index].vsComputer;
        localMultiplayer.text = locale[index].localMultiplayer;
        playOnline.text = locale[index].playOnline;
        playWithFriend.text = locale[index].playWithFriend;
        gameAudioVolume.text = locale[index].gameAudioVolume;
        languageText.text = locale[index].languageText;
        terms.text = locale[index].termsText;
        privacy.text = locale[index].privacyText;
        version.text = locale[index].versionText;
        deviceid.text = locale[index].deviceidText;
        PlayerPrefs.SetInt("lang", index);
    }
}
