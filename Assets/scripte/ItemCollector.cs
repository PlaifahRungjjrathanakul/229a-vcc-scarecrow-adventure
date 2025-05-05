using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public ParticleSystem pickupEffect;
    public AudioClip collector; 
    private AudioSource audioSource;

    
    public TextMeshProUGUI gemText;
    public TextMeshProUGUI cheeryText;

    
    private int gemValue = 0;
    private int cheeryValue = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.parent != null && collision.transform.parent.name == "item")
        {
            
            if (collision.gameObject.CompareTag("Gem"))
            {
                gemValue += 2;  
            }
            else if (collision.gameObject.CompareTag("Cheery"))
            {
                cheeryValue += 1;  
            }

            
            gemText.text = "" + gemValue.ToString();
            cheeryText.text = "" + cheeryValue.ToString();

           
            if (pickupEffect != null)
            {
                Instantiate(pickupEffect, collision.transform.position, Quaternion.identity);
                audioSource.PlayOneShot(collector);
            }

            
            Destroy(collision.gameObject);
        }
    }
}
