using UnityEngine;

public class Customer : MonoBehaviour
{
    public float patienceTime = 60f;
    public float moveSpeed = 2f;

    private float currentPatience;

    private CustomerManager customerManager;
    private Transform waitPoint;
    private Transform exitPoint;
    private Transform counter;

    private bool isEntering = true;
    private bool isLeaving = false;

    public void Initialize(
        CustomerManager manager,
        Transform destination,
        Transform exit,
        Transform counterTransform)
    {
        customerManager = manager;
        waitPoint = destination;
        exitPoint = exit;
        counter = counterTransform;

        currentPatience = patienceTime;
    }

    public bool IsWaitingAtCounter()
    {
        return !isEntering && !isLeaving;
    }

    void Update()
    {
        if (isEntering)
        {
            MoveToPoint(waitPoint);

            if (ReachedPoint(waitPoint))
            {
                isEntering = false;

                FaceCounter();
            }

            return;
        }

        if (isLeaving)
        {
            MoveToPoint(exitPoint);

            if (ReachedPoint(exitPoint))
            {
                customerManager.CustomerLeft();
                Destroy(gameObject);
            }

            return;
        }

        currentPatience -= Time.deltaTime;

        if (currentPatience <= 0f)
        {
            Leave();
        }
    }

    void MoveToPoint(Transform target)
    {
        if (target == null)
            return;

        Vector3 direction = target.position - transform.position;
        direction.y = 0f;

        if (direction.sqrMagnitude > 0.001f)
        {
            Quaternion targetRotation =
                Quaternion.LookRotation(direction);

            transform.rotation =
                Quaternion.RotateTowards(
                    transform.rotation,
                    targetRotation,
                    360f * Time.deltaTime
                );
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            moveSpeed * Time.deltaTime
        );
    }

    void FaceCounter()
    {
        if (counter == null)
            return;

        Vector3 direction =
            counter.position - transform.position;

        direction.y = 0f;

        if (direction.sqrMagnitude > 0.001f)
        {
            transform.rotation =
                Quaternion.LookRotation(direction);
        }
    }

    bool ReachedPoint(Transform target)
    {
        if (target == null)
            return false;

        return Vector3.Distance(
            transform.position,
            target.position
        ) < 0.05f;
    }

    public void Leave()
    {
        if (isLeaving)
            return;

        isEntering = false;
        isLeaving = true;
    }
}