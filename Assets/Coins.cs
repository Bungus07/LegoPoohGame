using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI AmountOfCoinsText;
    public int CoinsCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.GetComponent<Collectable>().collectCoin();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
