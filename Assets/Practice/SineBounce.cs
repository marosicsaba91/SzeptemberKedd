
using UnityEngine;

class SineBounce : MonoBehaviour
{
	[SerializeField] float maxHight = 10;
	[SerializeField] float speedMultiplier = 1;

	void Update()
    {
        float y = Mathf.Abs(Mathf.Sin(Time.time * speedMultiplier));
        Vector3 pos = transform.position;
        pos.y = y;
        transform.position = pos;
	}
}
