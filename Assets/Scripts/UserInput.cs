using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class UserInput : MonoBehaviour
{
    private uint userId;
    private uint symbolId;
    private string usernameKey = "";

    public AudioClip clickSound;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    AudioSource audioSource;

    public bool isExists;
    public string url = "http://127.0.0.1:8081/";

    private void Start()
    {
        usernameKey = "";
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClicked(string number)
    {
        audioSource.PlayOneShot(clickSound);
        if (number == "10")
        {
            SetUser();
        }
        else if (number == "11")
        {
            SignIn();
        }
        else
        {
            usernameKey += number;
        }
    }

    public void SignIn()
    {
        UserExistsFunction();
        if (isExists)
        {
            string savedUsername = PlayerPrefs.GetString(usernameKey, "");
            Debug.Log("correct");
            audioSource.PlayOneShot(correctSound);
            StartCoroutine(LoadNextSceneAfterDelay(1.5f, "AuthScene_2"));
        
            
        }
        else
        {
            Debug.Log("try again");
            usernameKey = "";
            audioSource.PlayOneShot(wrongSound);
        }
    }

    public void SaveUsernameAndLoadNextScene()
    {
        string username = usernameKey;
        PlayerPrefs.SetString("username", username);
        PlayerPrefs.Save();

        Debug.Log("correct");
        audioSource.PlayOneShot(correctSound);
        StartCoroutine(LoadNextSceneAfterDelay(1.5f, "AuthScene_2"));
    }

    public void SetUser()
    {
        string savedUsername = PlayerPrefs.GetString(usernameKey, "");
      
        Debug.Log("correct");
        audioSource.PlayOneShot(correctSound);
        StartCoroutine(LoadNextSceneAfterDelay(1.5f, "AuthScene_3"));
    
    }

    public void UserExistsFunction()
    {
        if (uint.TryParse(usernameKey, out uint userIdValue))
        {
            userId = userIdValue;
            Debug.Log("Exists: " + userId);
        }
        else
        {
            Debug.Log("Invalid userId input!");
        }
        var newUrl = url+ "userExists?userid=" + userId;

        StartCoroutine(GetRequest(newUrl, (response) =>
        {
            Debug.Log("User Exists Response: " + response);
            if (response == "false")
            {
                isExists = false;
            }
            else
            {
                isExists = true;
            }
        }));
    }

    private IEnumerator GetRequest(string url, System.Action<string> onResponse)
    {
        Debug.Log(url);
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Error while sending the request: " + webRequest.error);
            }
            else
            {
                string response = webRequest.downloadHandler.text;
                onResponse?.Invoke(response);
            }
        }
    }

    private IEnumerator LoadNextSceneAfterDelay(float delay, string sceneName)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

    
}



   



   
