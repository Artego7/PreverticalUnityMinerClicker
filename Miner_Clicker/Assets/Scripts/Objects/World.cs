using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "World", menuName = "World/Create", order = 1)]
public class World : ScriptableObject
{
    public int id;
    public string world;
    public List<Mineral> minerals;
    public List<string> nameOfZones;

    public void Print()
    {
        Debug.Log("id: " + id + ", name: " + world);
        for (int i = 0; i < minerals.Count; i++)
        {
            Debug.Log(", Mineral " + i + ": " + minerals[i].name);
        }
        for (int i = 0; i < nameOfZones.Count; i++)
        {
            Debug.Log(", Name of Zone " + i + ": " + nameOfZones[i]);
        }
    }

}
