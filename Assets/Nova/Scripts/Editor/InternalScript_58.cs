using Nova.InternalNamespace_17.InternalNamespace_22;
using UnityEditor;
using UnityEditor.Presets;
using UnityEngine;

namespace Nova.InternalNamespace_17
{
    internal static class InternalType_533
    {
        [MenuItem("GameObject/Nova/UIBlock 2D", false, 8)]
        private static void InternalMethod_2109(MenuCommand InternalParameter_2435)
        {
            InternalMethod_2113<UIBlock2D, InternalNamespace_21.InternalType_713>(InternalParameter_2435, "UIBlock2D").InternalMethod_73();
        }

        [MenuItem("GameObject/Nova/TextBlock", false, 9)]
        private static void InternalMethod_2110(MenuCommand InternalParameter_2436)
        {
            InternalMethod_2113<TextBlock, InternalNamespace_21.InternalType_713>(InternalParameter_2436, "TextBlock").InternalMethod_73();
        }

        [MenuItem("GameObject/Nova/UIBlock 3D", false, 10)]
        private static void InternalMethod_2111(MenuCommand InternalParameter_2437)
        {
            InternalMethod_2113<UIBlock3D, InternalNamespace_21.InternalType_713>(InternalParameter_2437, "UIBlock3D").InternalMethod_73();
        }

        [MenuItem("GameObject/Nova/UIBlock", false, 11)]
        private static void InternalMethod_2112(MenuCommand InternalParameter_2438)
        {
            InternalMethod_2113<UIBlock, InternalNamespace_21.InternalType_713>(InternalParameter_2438, "UIBlock").InternalMethod_73();
        }

        private static T InternalMethod_2113<T, TTool>(MenuCommand InternalParameter_2439, string InternalParameter_2440 = "GameObject") where T : Component where TTool : UnityEditor.EditorTools.EditorTool
        {
            GameObject InternalVar_1 = new GameObject(InternalParameter_2440);

            if (InternalParameter_2439.context is GameObject parent)
            {
                GameObjectUtility.SetParentAndAlign(InternalVar_1, parent);
            }
            else
            {
                UnityEditor.SceneManagement.StageUtility.PlaceGameObjectInCurrentStage(InternalVar_1);
            }

            T InternalVar_2 = InternalVar_1.AddComponent<T>();

            Preset[] InternalVar_3 = Preset.GetDefaultPresetsForObject(InternalVar_2);

            if (InternalVar_3 != null && InternalVar_3.Length > 0 && InternalVar_3[0] != null)
            {
                InternalVar_3[0].ApplyTo(InternalVar_2);
            }

            Undo.RegisterCreatedObjectUndo(InternalVar_1, "Create " + InternalVar_1.name);
            Selection.activeGameObject = InternalVar_1;

            EditorApplication.delayCall += () =>
            {
                if (!InternalType_779.InternalMethod_3699<T>(out _))
                {
                    return;
                }

                UnityEditor.EditorTools.ToolManager.SetActiveTool<TTool>();
            };

            return InternalVar_2;
        }
    }
}

