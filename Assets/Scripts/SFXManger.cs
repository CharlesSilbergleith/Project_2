using UnityEngine;

public class SFXManger : MonoBehaviour
{
    [Header("instance")]
    public static SFXManger Instance;
    [Header("audio Clips")]
    public AudioClip laser;
    public AudioClip explosion;
    public AudioClip highfrequency;
    public AudioClip Movement;
    [Header("aduio Source")]
    public AudioSource audioSource;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void expload() {
        audioSource.PlayOneShot(explosion);
    }
    public void shoot()
    {
        audioSource.PlayOneShot(laser);
    }

}
