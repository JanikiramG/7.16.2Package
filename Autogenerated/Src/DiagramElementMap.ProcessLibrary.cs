namespace Terrasoft.Configuration
{
	using Newtonsoft.Json.Linq;
	using Terrasoft.Core.Entities;
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Text.RegularExpressions;

	#region Class: DiagramElementMap

	public class DiagramElementMap
	{
		public DiagramElementMap(string schemaName, IEnumerable<DiagramElementMapPointer> pointers, 
				string referenceColumnValueName = "") {
			Pointers = pointers;
			SchemaName = schemaName;
			ReferenceColumnValueName = referenceColumnValueName;
		}

		public IEnumerable<DiagramElementMapPointer> Pointers {
			get;
			private set;
		}

		public string SchemaName {
			get;
			private set;
		}

		public string ReferenceColumnValueName {
			get;
			private set;
		}

		public string GetJTokenValueByPath(JToken jToken, string valuePath) {
			string[] paths = valuePath.Split('.');
			JToken node = jToken.DeepClone();
			foreach (string path in paths) {
				//Empty path instance means that's we go into array
				if (string.IsNullOrEmpty(path)) {
					if (node.Type == JTokenType.Array && node.HasValues) {
						node = node[0];
						continue;
					} else {
						node = null;
					}
				}
				if (node == null) {
					return string.Empty;
				}
				//If node is Object, go to the next step by path
				if (node.Type == JTokenType.Object) {
					node = node[path];
				} else {//When it's not and we not at the end of the path
					return string.Empty;
				}
				if (node == null) {
					return string.Empty;
				}
			}
			return node.ToString();
		}

		public void SetJObjectValueByPath(JToken jToken, string valuePath, object value, string prevPath = "") {
			if (string.IsNullOrEmpty(valuePath)) {
				return;
			}
			string[] paths = valuePath.Split('.');
			string currentPath = paths[0];
			Regex regex = new Regex("^" + currentPath + "(\\.+)?");
			string remainingPath = regex.Replace(valuePath, String.Empty);
			if (string.IsNullOrEmpty(remainingPath)) {
				//The end of path. CurrentPath is Parameter name. Set value.
				if (jToken.Type == JTokenType.Array) {
					JArray jArray = (JArray)jToken;
					jArray.Add(new JObject());
					jToken = jArray[0];
				}
				jToken[currentPath] = new JValue(value);
				return;
			}
			//Prepare new object by path
			JToken newToken = new JObject();
			//Create array
			for (int i = 1; i < paths.Length; i++) {
				if (string.IsNullOrEmpty(paths[i])) {
					newToken = new JArray();
				}
				break;
			}
			//Set next jToken and go down by path
			JToken nextToken;
			if (jToken.Type == JTokenType.Array) {
				if (!jToken.HasValues) {
					var jArray = (JArray)jToken;
					jArray.Add(newToken);
				}
				nextToken = jToken[0];
			} else {
				nextToken = jToken[currentPath];
			}
			if (nextToken == null) {
				jToken[currentPath] = newToken;
				nextToken = jToken[currentPath];
			}
			SetJObjectValueByPath(nextToken, remainingPath, value, currentPath);
		}

		public void Apply(Entity target, JToken source) {
			foreach (DiagramElementMapPointer pointer in Pointers) {
				string value = GetJTokenValueByPath(source, pointer.EntityColumnValueName);
				if (pointer.ValueType.Equals(typeof(String))) {
					target.SetColumnValue(pointer.ObjectPropertyPath, value);
					continue;
				}
				if (string.IsNullOrEmpty(value)) {
					target.SetColumnValue(pointer.ObjectPropertyPath, null);
					continue;
				}
				object parsedValue = null;
				object[] parameters = new object[] { value, parsedValue };
				bool parseResult = (bool)pointer.TryParseMethod.Invoke(null, parameters);
				if (parseResult) {
					parsedValue = parameters[1];
					target.SetColumnValue(pointer.ObjectPropertyPath, parsedValue);
				}
			}
		}

		public void Apply(JObject target, Entity source) {
			foreach (DiagramElementMapPointer pointer in Pointers) {
				object sourceValue = source.GetColumnValue(pointer.ObjectPropertyPath);
				if (sourceValue == null) {
					sourceValue = string.Empty;
				}
				SetJObjectValueByPath(target, pointer.EntityColumnValueName, sourceValue);
			}
			object id = source.GetColumnValue("Id");
			SetJObjectValueByPath(target, "name", id);
		}
	}

	#endregion

	#region Class: DiagramElementMapPointer

	public class DiagramElementMapPointer
	{
		public DiagramElementMapPointer(string entityColumnValueName, string objectPropertyPath, Type valueType) {
			EntityColumnValueName = entityColumnValueName;
			ObjectPropertyPath = objectPropertyPath;
			ValueType = valueType;
			_tryParseMethod = ValueType.GetMethod("TryParse");
		}

		private System.Reflection.MethodInfo _tryParseMethod;

		public string EntityColumnValueName {
			get;
			private set;
		}

		public string ObjectPropertyPath {
			get;
			private set;
		}

		public Type ValueType {
			get;
			private set;
		}

		public System.Reflection.MethodInfo TryParseMethod {
			get { return _tryParseMethod; }
		}

	}

	#endregion
}
