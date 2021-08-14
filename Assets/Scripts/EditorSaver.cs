using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEditor;

namespace com.flipmorris.editorsaver
{
	[InitializeOnLoad]
	public static class PlayModeStateChangedMethod
	{
		static PlayModeStateChangedMethod()
		{
			EditorApplication.playModeStateChanged += (state) =>
			{
				if (state == PlayModeStateChange.EnteredPlayMode)
				{
					EditorSaver.Instance.Update_DataBase();

					EditorSaver.Instance.Check_Avaliable_Data();
				}
				else if (state == PlayModeStateChange.ExitingPlayMode)
				{
					EditorSaver.Instance.Update_DataBase();
				}
				else if (state == PlayModeStateChange.EnteredEditMode)
				{
					EditorSaver.Instance.Check_Avaliable_Data();
				}
			};
		}
	}

	[InitializeOnLoad]
	[ExecuteInEditMode]
	public class EditorSaver : MonoBehaviour
	{
		string data;

		string filePath;

		public static EditorSaver Instance { get; set; }

		public bool update;

		public Objects_Container objectsContainer;

		public Transform[] hodlers;

		public GameObject[] baseHomeVariants;

		private void OnEnable()
		{
			if (Instance == null)
			{
				Instance = this;

				filePath = Path.Combine(Application.dataPath, "data.json");
			}
		}

		private void OnValidate()
		{
			if (update)
			{
				update = false;

				Check_Avaliable_Data();
			}
		}

		public void Check_Avaliable_Data()
		{
			if (!File.Exists(filePath))
			{
				return;
			}

			Load_Homes();
		}

		public void Load_Homes()
		{
			foreach (Transform t in hodlers)
			{
				if (t.childCount == 1)
				{
					DestroyImmediate(t.GetChild(0).gameObject);
				}
			}

			data = File.ReadAllText(filePath);

			objectsContainer = JsonUtility.FromJson<Objects_Container>(data);

			foreach (ObjectOnScene objectOnScene in objectsContainer.objectOnScenes)
			{
				int homeId = objectOnScene.prefabId;

				Transform homeParent = hodlers[objectOnScene.indexHolder];

				if (homeParent.childCount == 0)
				{
					GameObject home = Instantiate(baseHomeVariants[homeId], homeParent.position, homeParent.rotation, null);

					home.transform.SetParent(homeParent);
				}
			}
		}

		public bool DataNotEquals()
		{
			return !string.Equals(data, File.ReadAllText(filePath));
		}

		public void Update_DataBase()
		{
			objectsContainer.objectOnScenes.Clear();

			foreach (Transform t in hodlers)
			{
				if (t.childCount != 0)
				{
					ObjectOnScene objectOnScene = new ObjectOnScene
					{
						objectName = t.name,

						indexHolder = t.GetSiblingIndex(),

						prefabId = t.GetChild(0).GetComponent<MyObjectOnScene>().prefabId
					};

					AddToList(objectOnScene);
				}
			}

			data = JsonUtility.ToJson(objectsContainer);

			File.WriteAllText(filePath, data);
		}

		public void AddToList(ObjectOnScene objectOnScene)
		{
			List<int> ids = objectsContainer.objectOnScenes.Select(x => x.indexHolder).ToList();

			if (!ids.Contains(objectOnScene.indexHolder))
			{
				objectsContainer.objectOnScenes.Add(objectOnScene);
			}
		}

		public void Clean()
		{
			objectsContainer.objectOnScenes = new List<ObjectOnScene>();

			Update_DataBase();
		}

		[Serializable]
		public class Objects_Container
		{
			public List<ObjectOnScene> objectOnScenes;
		}

		[Serializable]
		public class ObjectOnScene
		{
			public string objectName;

			public int indexHolder;

			public int prefabId;
		}
	}
}
