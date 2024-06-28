using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawRate, spawRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}