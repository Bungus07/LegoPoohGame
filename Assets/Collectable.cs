using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI AmountOfCoinsText;
    private int CoinsCollected;
    public AudioClip CollectedSoundEffect;
    public AudioSource CoinAudioSource;
    public Coins CoinScript;

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CoinHasCollidedWith " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            CoinScript = collision.gameObject.GetComponent<Coins>();
            CoinScript.CoinsCollected++;
            CoinScript.AmountOfCoinsText.text ="Coins "+ CoinScript.CoinsCollected.ToString();
            CoinAudioSource.clip = CollectedSoundEffect;
            CoinAudioSource.Play();
            Destroy (gameObject);
        }
    }
}
