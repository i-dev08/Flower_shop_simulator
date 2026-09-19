using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public GameObject customerPrefab;
    public Transform customerSpawnPoint;
    public OrderManager orderManager;

    private GameObject currentCustomer;

    void Start()
    {
        SpawnCustomer();
    }

    public void SpawnCustomer()
    {
        if (currentCustomer != null)
        {
            Destroy(currentCustomer);
        }

        currentCustomer = Instantiate(
            customerPrefab,
            customerSpawnPoint.position,
            customerSpawnPoint.rotation
        );

        Customer customer = currentCustomer.GetComponentInParent<Customer>();

        customer.Initialize(this);

        orderManager.GenerateOrder();

        Debug.Log("CUSTOMER ARRIVED");
    }

    public void CustomerLeft()
    {
        currentCustomer = null;
        Invoke(nameof(SpawnCustomer),3f);
    }

    public void CustomerGotLeft()
    {
        currentCustomer = null;
        Invoke(nameof(SpawnCustomer),2f);
    }
}
