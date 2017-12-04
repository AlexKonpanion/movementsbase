using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Linq;

[CustomEditor(typeof(MeshCollider))]
public class ShowTriggers : Editor {

	public void SelectAllMeshTriggersInScene()
	{
		Selection.objects = FindObjectsOfType<MeshCollider>().Where(mc => mc.isTrigger && !mc.convex).Select(mc => mc.gameObject).ToArray();
	}

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        
        if (GUILayout.Button("Select Object"))
        {
            SelectAllMeshTriggersInScene();
        }
    }
	
}
