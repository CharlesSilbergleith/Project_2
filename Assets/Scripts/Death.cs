using UnityEngine;

abstract public class  Death : MonoBehaviour
{
    public abstract void Die();
    public void finalWords() {
        Debug.Log("I have Died");
    }

    public void finalWords(string words)
    {
        Debug.Log(words);
    }
}

