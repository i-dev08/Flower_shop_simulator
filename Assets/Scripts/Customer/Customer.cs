using UnityEngine;

public class Customer : MonoBehaviour
{
    public float patienceTime = 60f;
    private float currentPatience;
    private CustomerManager customerManager;

    public void Initialize(CustomerManager manager)
    {
        customerManager = manager;
        currentPatience = patienceTime;
    }
    void Start()
    {
        currentPatience = patienceTime;
    }
    void Update()
    {
        currentPatience -= Time.deltaTime;

        if(currentPatience <= 0f)
        {
            Leave();
        }
    }

    void Leave()
    {
        Debug.Log("Customer left because they waited too long");
        customerManager.CustomerLeft();
        Destroy(gameObject);
    }
}
