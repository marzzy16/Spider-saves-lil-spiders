
using UnityEngine;

public static class PreferencesManager
{
    /// <summary>
    /// public static method that returns a float, named GetMusicVolume and returns PlayerPrefs.GetFloat("MusicVolume", 1).
    /// </summary>
    /// <returns></returns>
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }
    /// <summary>
    /// A public static method that returns a float, named GetMasterVolume and returns PlayerPrefs.GetFloat("MasterVolume", 1) .
    /// </summary>
    /// <returns></returns>
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }
    /// <summary>
    /// A public static method that has a float parameter called soundLevel that adds sound to the "MusicVolume".
    /// </summary>
    /// <param name="soundLevel"></param>
    public static void SetMusicVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
    /// <summary>
    /// A public static method that has a float parameter called soundLevel that adds sound to the "MasterVolume".
    /// </summary>
    /// <param name="soundLevel"></param>
    public static void SetMasterVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }
}

