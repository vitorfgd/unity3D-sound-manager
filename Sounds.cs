using UnityEngine;
using System.Collections;

public enum SoundsGame{
	sound1,
	sound2,
}

public class Sounds : MonoBehaviour {

	public AudioClip _sound1;
	public AudioClip _sound2;

	public static Sounds instance;

	void Start () {
		instance = this;
	}

	public static void PlaySound (SoundsGame currentSound){
		switch (currentSound) {
			case SoundsGame.sound1:{
				instance.GetComponent<AudioSource>().PlayOneShot (instance._sound1);
			} break;
			case SoundsGame.sound2:{
				instance.GetComponent<AudioSource>().PlayOneShot (instance._sound2);
			} break;
		}
	}
}
