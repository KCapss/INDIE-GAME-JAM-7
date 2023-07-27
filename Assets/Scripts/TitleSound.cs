using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSound : MonoBehaviour
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
        
    }

   
    private void playLoading()
    {

        activePlay.PlayOneShot(AudioManager.Instance.RetreiveTitleMsc());
    }

    private void OnDestroy()
    {
        activePlay.Stop();
    }

    IEnumerator playClip()
    {

        playLoading();
        yield return new WaitForSeconds(5f);
        
    }
}
