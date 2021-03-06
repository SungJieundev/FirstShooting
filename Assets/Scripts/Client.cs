using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

public class Client : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] InputField nicknameInput;
    WebSocket _client;

    private void Start()
    {
        _client = new WebSocket("ws://localhost:8080");

        _client.OnOpen += (sender, e) =>
        {
            Debug.Log("???? ????!");
        };

        _client.OnMessage += onMessage;
        _client.ConnectAsync();
    }

    private void onMessage(object sender, MessageEventArgs e)
    {


        string result = e.Data.Replace('|', '\n').Replace(",", ": ");
        scoreText.text = result;
    }

    public void SubmitScore()
    {
        string data = "score:" + nicknameInput.text + "," + UIManager.Instance.score;
        _client.Send(data);
    }
}
