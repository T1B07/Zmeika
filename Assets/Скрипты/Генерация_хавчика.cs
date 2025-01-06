using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject XY0, X1, Y1;
    public GameObject ’ј¬ ј;

    GameObject —сылкаЌаќбъект = null;
    

    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if (—сылкаЌаќбъект == null)
        {
            float x0 = XY0.transform.position.x;
            float x1 = X1.transform.position.x;
            float y0 = XY0.transform.position.z;
            float y1 = Y1.transform.position.z;

            float X = Random.Range(x0, x1);
            float Y = Random.Range(y0, y1);

            Vector3  уда—тавить = new Vector3(X, 0, Y);

            —сылкаЌаќбъект = Instantiate(’ј¬ ј,  уда—тавить, Quaternion.identity);
        }
        if(—сылкаЌаќбъект.GetComponent<SphereCollider>().isTrigger)
        {
            Destroy(—сылкаЌаќбъект, 1.0f);
        }
    }
}
