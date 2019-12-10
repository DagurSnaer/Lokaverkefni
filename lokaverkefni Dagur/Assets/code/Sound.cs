using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound {

    public string name; // adds a name option

    public AudioClip clip; // adds a clip option

    [Range(0f, 1f)]
    public float volume; // adds a volume option with a range of 0-1
    [Range(.1f, 3f)]
    public float pitch; // adds a  pitch option with a range of 0.1-3

    public bool loop; // adds a loop option is AudioManager

    [HideInInspector]
    public AudioSource source;

}
