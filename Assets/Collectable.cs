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
    private int MaxCoins;
    private GameObject[] AllCoins;

    private void Start()
    {
        CoinScript = GameObject.Find("Winne (1) Variant").GetComponent<Coins>();
        AllCoins = GameObject.FindGameObjectsWithTag("Coin");
        CoinScript.AmountOfCoinsText.text = "Coins " + "0/" + AllCoins.Length;
    }
    public void collectCoin()
    {
        CoinScript.CoinsCollected++;
        CoinScript.AmountOfCoinsText.text = "Coins " + CoinScript.CoinsCollected.ToString() + "/" + AllCoins.Length.ToString();
        if (CoinScript.CoinsCollected >= AllCoins.Length)
        {
            Debug.Log("AllCoinsBeenCollected");
        }
        CoinAudioSource.clip = CollectedSoundEffect;
        CoinAudioSource.Play();
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CoinHasCollidedWith " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }
}
