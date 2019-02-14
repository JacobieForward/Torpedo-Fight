using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoController : MonoBehaviour {

    private GameObject m_TorpedoPrefab;
    private List<GameObject> TorpedoList;

    private int numTorpedoes;
    private float TorpedoTime;
    private float TorpedoTimer;

    void Start () {
        m_TorpedoPrefab = Resources.Load<GameObject>("Prefabs/Torpedo");
        SpawnTorpedoes();
	}
	
	void Update () {
        TorpedoTimer += Time.deltaTime;
    }

    private void SpawnTorpedoes()
    {
        if (m_TorpedoPrefab != null)
        {
            GameObject TorpedoRightInstance = Instantiate(m_TorpedoPrefab, new Vector3(0, 0, Random.Range(-10, 10)), new Quaternion(90, 90, 0, 1));
            GameObject TorpedoLeftInstance = Instantiate(m_TorpedoPrefab, new Vector3(0, 0, Random.Range(-10, 10)), new Quaternion(90, -90, 0, 1));
            TorpedoList.Add(TorpedoRightInstance);
            TorpedoList.Add(TorpedoLeftInstance);
        } else
        {
            Debug.Log("Torpedo Prefab Null for function SpawnTorpedoes See Trace: \n" + UnityEngine.StackTraceUtility.ExtractStackTrace());
        }
    }
}
