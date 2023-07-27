using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField] private AudioSource activePlay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playClip());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Goal"))
                {
                    // you hit it
                    Debug.LogError("You won");
                    GameManager.Instance.YouWin();

                }

                Debug.LogWarning(hit.collider.gameObject.name);

            }
            
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.red, 10000);
        }
    }

    private void playDialogue()
    {
        activePlay.PlayOneShot(AudioManager.Instance.RetrieveDialogue());
    }

    private void playShoppingSpree()
    {
        
        activePlay.PlayOneShot(AudioManager.Instance.RetrieveInGameMsc()); 
    }

    private void OnDestroy()
    {
        activePlay.Stop();
    }

    IEnumerator playClip()
    {

        playDialogue();
        yield return new WaitForSeconds(5f);
        playShoppingSpree();
    }
}
