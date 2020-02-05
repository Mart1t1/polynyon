using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = System.Random;

/*
Script final du lobby, le reste est du trash file
*/

public class PhotonLobby : MonoBehaviourPunCallbacks
{
    
    public static PhotonLobby lobby;



    public GameObject CreateOrjoinButton;

    public GameObject Cancel;
    
    public InputField nom;
    
    // Start is called before the first frame update
    private void Awake()
    {
        lobby = this;
        PhotonNetwork.AutomaticallySyncScene = true;
        
    }


    private void Start()
    {

        PhotonNetwork.ConnectUsingSettings();
    }
    
    

    public void OnJoinOrCreateButton()
    {

        JoinOrCreateRoom();
    }

    public void OnCancelClick()
    {

        PhotonNetwork.LeaveRoom();
        
    }

    private void JoinOrCreateRoom()
    {
        string nomchambre = nom.text;
        RoomOptions RoomOps = new RoomOptions(){IsVisible = true, IsOpen = true, MaxPlayers = 2};
        Debug.Log("On cree une chambre ID : " +nomchambre);

        PhotonNetwork.JoinOrCreateRoom(nomchambre, RoomOps, TypedLobby.Default);

    }

    public override void OnJoinedRoom()
    {
        Debug.Log("On est dans une room + "+ PhotonNetwork.CurrentRoom.Name
        + "avec {1} joueurs" +PhotonNetwork.CurrentRoom.Players.Count);
    }

    private void Update()
    {
        if(PhotonNetwork.InRoom)
            Debug.Log(Convert.ToString(PhotonNetwork.CurrentRoom.PlayerCount));
    }
}
