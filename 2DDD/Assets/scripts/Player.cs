
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Final;
    private void OnTriggerEnter2D(Collider2D collision)
        {
        Final.SetActive(true);
        
    }
}
