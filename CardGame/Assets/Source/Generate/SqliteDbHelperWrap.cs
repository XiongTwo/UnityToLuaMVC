﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SqliteDbHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SqliteDbHelper), typeof(System.Object));
		L.RegFunction("OpenDB", OpenDB);
		L.RegFunction("CloseSqlConnection", CloseSqlConnection);
		L.RegFunction("ExecuteQuery", ExecuteQuery);
		L.RegFunction("ReadFullTable", ReadFullTable);
		L.RegFunction("InsertInto", InsertInto);
		L.RegFunction("UpdateInto", UpdateInto);
		L.RegFunction("Delete", Delete);
		L.RegFunction("InsertIntoSpecific", InsertIntoSpecific);
		L.RegFunction("DeleteContents", DeleteContents);
		L.RegFunction("CreateTable", CreateTable);
		L.RegFunction("SelectWhere", SelectWhere);
		L.RegFunction("New", _CreateSqliteDbHelper);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSqliteDbHelper(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				SqliteDbHelper obj = new SqliteDbHelper(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SqliteDbHelper.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenDB(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			obj.OpenDB(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseSqlConnection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			obj.CloseSqlConnection();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExecuteQuery(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			Mono.Data.Sqlite.SqliteDataReader o = obj.ExecuteQuery(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFullTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			Mono.Data.Sqlite.SqliteDataReader o = obj.ReadFullTable(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InsertInto(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			Mono.Data.Sqlite.SqliteDataReader o = obj.InsertInto(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateInto(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			string[] arg2 = ToLua.CheckStringArray(L, 4);
			string arg3 = ToLua.CheckString(L, 5);
			string arg4 = ToLua.CheckString(L, 6);
			Mono.Data.Sqlite.SqliteDataReader o = obj.UpdateInto(arg0, arg1, arg2, arg3, arg4);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Delete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			string[] arg2 = ToLua.CheckStringArray(L, 4);
			Mono.Data.Sqlite.SqliteDataReader o = obj.Delete(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InsertIntoSpecific(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			string[] arg2 = ToLua.CheckStringArray(L, 4);
			Mono.Data.Sqlite.SqliteDataReader o = obj.InsertIntoSpecific(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeleteContents(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			Mono.Data.Sqlite.SqliteDataReader o = obj.DeleteContents(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			string[] arg2 = ToLua.CheckStringArray(L, 4);
			Mono.Data.Sqlite.SqliteDataReader o = obj.CreateTable(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SelectWhere(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			SqliteDbHelper obj = (SqliteDbHelper)ToLua.CheckObject(L, 1, typeof(SqliteDbHelper));
			string arg0 = ToLua.CheckString(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			string[] arg2 = ToLua.CheckStringArray(L, 4);
			string[] arg3 = ToLua.CheckStringArray(L, 5);
			string[] arg4 = ToLua.CheckStringArray(L, 6);
			Mono.Data.Sqlite.SqliteDataReader o = obj.SelectWhere(arg0, arg1, arg2, arg3, arg4);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
