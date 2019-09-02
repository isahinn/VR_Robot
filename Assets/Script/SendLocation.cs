using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Assets.Script;
using Valve.VR;

public class SendLocation : MonoBehaviour
{
    public float xp, yp, zp;
    public float xr, yr, zr;
    public string[] targetAdress;
    public Vector3 Position { get; set; }
    public Vector3 Rotation { get; set; }

    private PlcConnect plcConnect = new PlcConnect();
    public void Start()
    {
       
    }
    public void Update()
    {
        
    }

   
    public void positionData(Transform position)
    {
        try
        {
            plcConnect.sendData(position.position.x, targetAdress[0]);
            plcConnect.sendData(position.position.y, targetAdress[1]);
            plcConnect.sendData(position.position.z, targetAdress[2]);
        }
        catch (Exception exp) { Debug.LogError(exp.ToString()); }
    }
    public void rotationData(Transform rotation)
    {
        try
        {
            plcConnect.sendData(rotation.rotation.x, targetAdress[3]);
            plcConnect.sendData(rotation.rotation.y, targetAdress[4]);
            plcConnect.sendData(rotation.rotation.z, targetAdress[5]);
        }
        catch (Exception exp) { Debug.LogError(exp.ToString()); }
    }

    public void TestData2()
    {
        StartCoroutine(plcConnect.SendAsyncData(xp, ""));
    }    
}




