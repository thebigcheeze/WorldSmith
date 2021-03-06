/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Add %AbilityName to %Target")]
	public partial class AddAbility : TargetedAction
	{
		public AddAbility(KeyValue kv)
			: base(kv)
		{
		}
		public AddAbility(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilityName
		{
			get
			{
				KeyValue kv = GetSubkey("AbilityName");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("AbilityName");
				if(kv == null)
				{
					kv = new KeyValue("AbilityName");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
