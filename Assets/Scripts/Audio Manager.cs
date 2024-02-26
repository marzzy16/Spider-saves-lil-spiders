using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
/// <summary>
/// added UnityEngine.UI; and UnityEngine.Audio;
/// </summary>
public class AudioManager : MonoBehaviour
{
   /// <summary>
   /// A public AudioMixer variable called masterMixer.
   /// </summary>
    private static AudioManager instance;

    public static AudioManager Instance { get { return instance; } }

    public AudioMixer masterMixer;
    public Slider musicSlider, masterSlider;


    /// <summary>
    ///Makes the object not be destroyed on the load scene.
    /// </summary>
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
  
    void Start()
    {
        /// <summary>
        /// Calls SetMasterVolume from the PreferencesManager class and pass in soundLevel as the argument.
        /// </summary>
        /// 

        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMasterVolume());

        /// <summary>
        /// Calls SetMusicVolume from the PreferencesManager class and pass in soundLevel as the argument.
        /// </summary>
        /// 

        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());


        /// <summary>
        ///  public Slider variables, called masterSlider..
        /// </summary>
        ///
        if (masterSlider != null)
            PreferencesManager.GetMasterVolume();

        /// <summary>
        /// A public Slider variables, called musicSlider.
        /// </summary>
        ///
        if (musicSlider != null)
            PreferencesManager.GetMusicVolume();
    }

    /// <summary>
    /// A public method that takes a float as a parameter, soundLevel that changes the "MasterVol" sound level.
    /// </summary>
    /// <param name="soundLevel"></param>
    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    /// <summary>
    /// A public method that takes a float as a parameter, soundLevel that changes the "MusicVol" sound level.
    /// </summary>
    /// <param name="soundLevel"></param>
    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }
}
