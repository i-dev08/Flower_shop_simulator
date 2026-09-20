using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public GameObject boyCustomerPrefab;
    public GameObject girlCustomerPrefab;
    public Transform customerSpawnPoint;
    public OrderManager orderManager;
    public Transform customerWaitPoint;
    public Transform customerExitPoint;
    public Transform counter;

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

        GameObject selectedPrefab;

        if (Random.Range(0,2) == 0)
        {
            selectedPrefab = boyCustomerPrefab;
        } 
        else {
            selectedPrefab = girlCustomerPrefab;
        }

        currentCustomer = Instantiate(
            selectedPrefab,
            customerSpawnPoint.position,
            customerSpawnPoint.rotation
        );

        Customer customer = currentCustomer.GetComponentInParent<Customer>();

        customer.Initialize(this, customerWaitPoint, customerExitPoint, counter);

        orderManager.GenerateOrder();

        Debug.Log("CUSTOMER ARRIVED");
    }

    public void CustomerLeft()
    {
        currentCustomer = null;
        SpawnCustomer();
    }

    public GameObject GetCurrentCustomer() 
    {
        return currentCustomer;
    }
}
