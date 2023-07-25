using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class SignIn : MonoBehaviour
{
    public uint symbolId = 1;
    public uint userId ;
    private bool isButtonClicked = false;
    public string username;

    private void Start()
    {
        string username = PlayerPrefs.GetString("username", "");
        Debug.Log("Welcome " + username + "!");

       if (uint.TryParse(username, out uint userIdValue))
        {
            userId = userIdValue;
            Debug.Log("UserId: " + userId + ", SymbolId: " + symbolId);
        }
        else
        {
            Debug.Log("Invalid userId or symbolId input!");
        }
        
    }

    private void Update()
    {
        
        if (isButtonClicked)
        {
            
            var url = "http://127.0.0.1:8081/";
        
 
        
           var newUrl = url + "checkSymbol?symbolid=" + symbolId + "&userid=" + userId;
            StartCoroutine(GetRequest(newUrl, (response) =>
            {
                Debug.Log("Check Symbol Response: " + response);
                if (response == "false")
                {
                    SceneManager.LoadScene("SampleScene");
                }
                else
                {
                    SceneManager.LoadScene("GameScene");
                }
            }));

            isButtonClicked = false;
        } 
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

    public void firstButtonFunction()
    {
        symbolId = 1;
        isButtonClicked = true;
        
    }

    public void secondButtonFunction()
    {
        symbolId = 2;
        isButtonClicked = true;
    }

    public void thirdButtonFunction()
    {
        symbolId = 3;
        isButtonClicked = true;
    }
}