using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 10;
	void FixedUpdate ()
	{
		//    入力をｘとｚに代入
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");

		//同一のGameObjectが持つRigidbodyコンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		//rigidbodyのｘ軸（横）とｚ軸（奥）に力を加える
		rigidbody.AddForce(x * speed , 0, z * speed);
	}
}