using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public TMP_InputField input_Create;
    public TMP_InputField input_Join;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(input_Create.text);

    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(input_Join.text);

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Gameplay");
    }
}
