using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public GameObject cat;
    [SerializeField] public float _speed;
    public Vector3 batPosition;
    public Vector3 catPosition;

    public void EnableChasing()
    {
        enabled = true;
    }

    public void DisableChasing()
    {
        enabled = false;
    }

    private void Update()
    {
        catPosition = cat.GetComponent<Transform>().position;
        batPosition = gameObject.GetComponent<Transform>().position;
        transform.position = Vector3.MoveTowards(batPosition, catPosition, _speed * Time.deltaTime);
    }
}
