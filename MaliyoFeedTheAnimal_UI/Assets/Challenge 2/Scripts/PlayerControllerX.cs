using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeDelay = 1f;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // On spacebar press, send dog and check if the delay have been reached to avoid spamming
        if (Input.GetKeyDown(KeyCode.Space) && (timer >= timeDelay))
        {
            SpawnDog();
            timer = 0;

        }

    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
