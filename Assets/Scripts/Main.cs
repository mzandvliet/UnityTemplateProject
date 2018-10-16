using UnityEngine;
using Unity.Burst;
using Unity.Jobs;
using Unity.Collections;
using Unity.Mathematics;
using Rng = Unity.Mathematics.Random;

public class Main : MonoBehaviour {
	private NativeArray<float2> _points;
	private Rng _rng;

	private void Awake () {
		_points = new NativeArray<float2>(3, Allocator.Persistent);

		_rng = new Rng(1234);
    }

	private void OnDestroy() {
		_points.Dispose();
	}
	
	private void Update () {
		
	}

	private void OnDrawGizmos() {
		if (!Application.isPlaying) {
			return;
		}

		Gizmos.color = Color.blue;
	}

	private void OnGUI() {
		GUILayout.Label("Hello: ");
	}
}

public static class Util {
	public static Vector3 ToVec3(float2 p) {
		return new Vector3(p.x, p.y, 0f);
	}
}
