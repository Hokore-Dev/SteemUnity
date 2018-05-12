using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJson;
using SimpleJSON;
using System.IO;

[CustomEditor(typeof(APIGenerator))]
public class APIGeneratorEditor : Editor
{      
    private APIGenerator _api;
    private WWW _request;

    public override void OnInspectorGUI()
    {
        _api = (APIGenerator)target;
        base.OnInspectorGUI();

        GUILayout.BeginHorizontal();
        {
            if (GUILayout.Button("Renew API File", GUILayout.Height(50)) && _request == null)
            {
                _request = new WWW(_api.apiUrl);
            }
            if (GUILayout.Button("Open API Data", GUILayout.Height(50), GUILayout.Width(100)))
            {
                Application.OpenURL(_api.apiUrl);
            }
        }
        GUILayout.EndHorizontal();

        if (_request != null && _request.isDone)
        {
            if( string.IsNullOrEmpty(_request.error ) )
            {
                GenerateSourceCode(MakeJsonFormat(_request.text));    
            }
            else
            {
                Debug.LogError(_request.error);
            }
            _request.Dispose();
            _request = null;
        }
        
        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }

    private string MakeJsonFormat(string inData)
    {
        string[] splitStrings = inData.Split('\n');
        System.Text.StringBuilder sb = new StringBuilder("[\n");
        for (int i = 1; i < splitStrings.Length - 2; i++)
        {
            sb.Append(splitStrings[i]);
            sb.AppendLine();
        }
        sb.Append("]");
        return sb.ToString();
    }

    private void GenerateSourceCode(string inJson)
    {
        string codePrefix  = "public class SteemitAPI\n{\n\t/// Auto Generated Begin\n";
        string codePostfix = "\t/// Auto Generated End\n}";
        
        StringBuilder code  = new StringBuilder(codePrefix);
        JSONArray     array = JSONNode.Parse(inJson).AsArray;
        for (int i = 0; i < array.Count; i++)
        {
            List<string> paramList = new List<string>();
            string apiName = array[i]["api"];
            string method  = array[i]["method"];

            if (!string.IsNullOrEmpty(array[i]["method_name"]))
            {
                method = array[i]["method_name"];
            }
            
            JSONArray paramArray = array[i]["params"].AsArray;
            for (int k = 0; k < paramArray.Count; k++)
            {
                paramList.Add(paramArray[k]);
            }

            code.AppendFormat("\n\tprivate void {0}(", method);
            foreach (var param in paramList)
            {
                code.AppendFormat("string {0},", param);
            }
            if (paramList.Count > 0)
            {
                code.Remove(code.Length - 1, 1);
            }
            code.Append(")\n\t{\n");
            
            // BODY

            code.Append("\t}\n");
            Debug.Log(string.Format("[{0}] method : {1}", apiName, method));
        }
        code.Append(codePostfix);
        
        Debug.Log(string.Format("=== Load Done {0} api", array.Count));
        File.WriteAllText(_api.scriptPath, code.ToString(), System.Text.Encoding.UTF8);
        AssetDatabase.Refresh();
    }
}
