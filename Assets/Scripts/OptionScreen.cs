using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionScreen : MonoBehaviour
{
	
	public Toggle fullScreenTog;
	
	public TMP_Text musicLabel;
	public Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        fullScreenTog.isOn = Screen.fullScreen;
    }
	
	public void ApplyChanges()
	{
		Screen.fullScreen = fullScreenTog.isOn;
		
	}
	
	public void SetMusicVol()
	{
		musicLabel.text = Mathf.RoundToInt(musicSlider.value).ToString();
	}

    // Update is called once per frame
    void Update()
    {
        Screen.fullScreen = fullScreenTog.isOn;
    }
}
