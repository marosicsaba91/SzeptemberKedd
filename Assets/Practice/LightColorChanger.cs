using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
	[SerializeField] Color color1 = Color.red;
	[SerializeField] Color color2 = Color.blue;

	[SerializeField] Light light;
	[SerializeField] float speedMultiplier;

	void Update()
	{
		float t = Mathf.Sin(Time.time * speedMultiplier);

		// t = (t / 2f) + 0.5f;
		// t = Mathf.Pow(t, 2);
		t = t * t;

		Color c = Color.Lerp(color1, color2, t); 

		light.color = c;
	}
}
