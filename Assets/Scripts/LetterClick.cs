using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterClick : MonoBehaviour
{
    IEnumerator OnMouseDown()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("FinalGAME");
    }
}
