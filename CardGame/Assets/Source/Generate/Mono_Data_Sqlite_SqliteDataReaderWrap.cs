﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Mono_Data_Sqlite_SqliteDataReaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Mono.Data.Sqlite.SqliteDataReader), typeof(System.Data.Common.DbDataReader));
		L.RegFunction("Close", Close);
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("GetBoolean", GetBoolean);
		L.RegFunction("GetByte", GetByte);
		L.RegFunction("GetBytes", GetBytes);
		L.RegFunction("GetChar", GetChar);
		L.RegFunction("GetChars", GetChars);
		L.RegFunction("GetDataTypeName", GetDataTypeName);
		L.RegFunction("GetDateTime", GetDateTime);
		L.RegFunction("GetDecimal", GetDecimal);
		L.RegFunction("GetDouble", GetDouble);
		L.RegFunction("GetFieldType", GetFieldType);
		L.RegFunction("GetFloat", GetFloat);
		L.RegFunction("GetGuid", GetGuid);
		L.RegFunction("GetInt16", GetInt16);
		L.RegFunction("GetInt32", GetInt32);
		L.RegFunction("GetInt64", GetInt64);
		L.RegFunction("GetName", GetName);
		L.RegFunction("GetOrdinal", GetOrdinal);
		L.RegFunction("GetSchemaTable", GetSchemaTable);
		L.RegFunction("GetString", GetString);
		L.RegFunction("GetValue", GetValue);
		L.RegFunction("GetValues", GetValues);
		L.RegFunction("IsDBNull", IsDBNull);
		L.RegFunction("NextResult", NextResult);
		L.RegFunction("Read", Read);
		L.RegFunction("get_Item", get_Item);
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Depth", get_Depth, null);
		L.RegVar("FieldCount", get_FieldCount, null);
		L.RegVar("VisibleFieldCount", get_VisibleFieldCount, null);
		L.RegVar("HasRows", get_HasRows, null);
		L.RegVar("IsClosed", get_IsClosed, null);
		L.RegVar("RecordsAffected", get_RecordsAffected, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader), typeof(int)))
			{
				Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				object o = obj[arg0];
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader), typeof(string)))
			{
				Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object o = obj[arg0];
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to operator method: Mono.Data.Sqlite.SqliteDataReader.this");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, null);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			obj.Close();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			System.Collections.IEnumerator o = obj.GetEnumerator();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBoolean(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.GetBoolean(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte o = obj.GetByte(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			long arg1 = LuaDLL.tolua_checkint64(L, 3);
			byte[] arg2 = ToLua.CheckByteBuffer(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
			long o = obj.GetBytes(arg0, arg1, arg2, arg3, arg4);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			char o = obj.GetChar(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChars(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			long arg1 = LuaDLL.tolua_checkint64(L, 3);
			char[] arg2 = ToLua.CheckCharBuffer(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
			long o = obj.GetChars(arg0, arg1, arg2, arg3, arg4);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDataTypeName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string o = obj.GetDataTypeName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDateTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.DateTime o = obj.GetDateTime(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDecimal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			decimal o = obj.GetDecimal(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDouble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			double o = obj.GetDouble(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFieldType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Type o = obj.GetFieldType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = obj.GetFloat(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGuid(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Guid o = obj.GetGuid(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt16(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			short o = obj.GetInt16(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.GetInt32(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			long o = obj.GetInt64(arg0);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string o = obj.GetName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOrdinal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			string arg0 = ToLua.CheckString(L, 2);
			int o = obj.GetOrdinal(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSchemaTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			System.Data.DataTable o = obj.GetSchemaTable();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string o = obj.GetString(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object o = obj.GetValue(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetValues(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			object[] arg0 = ToLua.CheckObjectArray(L, 2);
			int o = obj.GetValues(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDBNull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.IsDBNull(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NextResult(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			bool o = obj.NextResult();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Read(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.CheckObject(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader));
			bool o = obj.Read();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader), typeof(int)))
			{
				Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				object o = obj[arg0];
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(Mono.Data.Sqlite.SqliteDataReader), typeof(string)))
			{
				Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object o = obj[arg0];
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Mono.Data.Sqlite.SqliteDataReader.get_Item");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			int ret = obj.Depth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Depth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FieldCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			int ret = obj.FieldCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index FieldCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_VisibleFieldCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			int ret = obj.VisibleFieldCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index VisibleFieldCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HasRows(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			bool ret = obj.HasRows;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index HasRows on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsClosed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			bool ret = obj.IsClosed;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsClosed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RecordsAffected(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mono.Data.Sqlite.SqliteDataReader obj = (Mono.Data.Sqlite.SqliteDataReader)o;
			int ret = obj.RecordsAffected;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index RecordsAffected on a nil value" : e.Message);
		}
	}
}
