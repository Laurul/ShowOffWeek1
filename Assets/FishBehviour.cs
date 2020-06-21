

using UnityEngine;

public class FishBehviour : MonoBehaviour
{
    private bool outOf = false;
    public Vector3 pos2;
    private Vector3 initialPosition;
    private Vector3 destination;
    private Vector3 nextPos;
    private bool switchOperation = false;
    [SerializeField] private float timeUp = 1f;
    [SerializeField] private float timerLeft = 1f;

    float timeDown = 1f;
    private GameObject player;
    private Quaternion facing;

    private int roll;
    [SerializeField] private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(this.gameObject, 20f);
        facing = transform.localRotation;

        destination = pos2;
        initialPosition = this.transform.position;
        timeUp = timerLeft;
        // timeDown = timerLeft;
        roll = Random.Range(0, 2);
        CalculateTrajectory(transform.position);
        pos2 = nextPos;

        // transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //var rotation = Quaternion.LookRotation(nextPos.normalized);
        // rotation *= facing;
        // transform.rotation = rotation;

        if (this.transform.position == destination) Destroy(this.gameObject);

        //transform.LookAt(player.transform);


        timeUp -= Time.deltaTime;
        //Debug.Log(timeUp);
        if (timeUp < 0 || this.transform.position == pos2)
        {


            roll = Random.Range(0, 3);
            CalculateTrajectory(transform.position);

            pos2 = nextPos;


            timeUp = timerLeft;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        // transform.position = Vector3.MoveTowards(transform.position, nextPos,0.02f * Time.deltaTime);



    }
    private void CalculateTrajectory(Vector3 actualPosition)
    {

        float x;
        float fux;
        fux = actualPosition.y;
        x = actualPosition.z;
        if (roll == 0)
        { fux = Mathf.Sin(x) * Random.Range(0, 3); }
        else if (roll == 1)
        { fux = Mathf.Cos(x) * Random.Range(0, 3); }

        nextPos = new Vector3(actualPosition.x - Random.Range(1.5f, 3f), fux, x);
        // Debug.Log("FUX: " + fux);

    }
    private void OnTriggerStay(Collider other)
    {


    }
    private void OnTriggerExit(Collider other)
    {//if(other.tag=="aquarium")
     //  { pos2 = destination; }
    }

}
