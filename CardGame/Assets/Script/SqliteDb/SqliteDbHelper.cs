using UnityEngine;
using System.Collections;
//导入sqlite数据集，也就是Plugins文件夹下的那个dll文件
using Mono.Data.Sqlite;
using System;
//数据集 是formwork2.0 用vs开发要自己引用框架中的System.Data
using System.Data;
public class SqliteDbHelper
{
    /// <summary>
    /// 声明一个连接对象
    /// </summary>
    private SqliteConnection dbConnection;
    /// <summary>
    /// 声明一个操作数据库命令
    /// </summary>
    private SqliteCommand dbCommand;
    /// <summary>
    /// 声明一个读取结果集的一个或多个结果流
    /// </summary>
    private SqliteDataReader reader;
    /// <summary>
    /// 数据库的连接字符串，用于建立与特定数据源的连接
    /// </summary>
    /// <param name="connectionString">数据库的连接字符串，用于建立与特定数据源的连接</param>
    public SqliteDbHelper(string connectionString)
    {
        OpenDB(connectionString);
        Debug.Log(connectionString);
    }
    public void OpenDB(string connectionString)
    {
        try
        {
            dbConnection = new SqliteConnection(connectionString);
            dbConnection.Open();
            Debug.Log("Connected to db");
        }
        catch (Exception e)
        {
            string temp1 = e.ToString();
            Debug.Log(temp1);
        }
    }
    /// <summary>
    /// 关闭连接
    /// </summary>
    public void CloseSqlConnection()
    {
        if (dbCommand != null)
        {
            dbCommand.Dispose();
        }
        dbCommand = null;
        if (reader != null)
        {
            reader.Dispose();
        }
        reader = null;
        if (dbConnection != null)
        {
            dbConnection.Close();
        }
        dbConnection = null;
        Debug.Log("Disconnected from db.");
    }
    /// <summary>
    /// 执行查询sqlite语句操作
    /// </summary>
    /// <param name="sqlQuery"></param>
    /// <returns></returns>
    public SqliteDataReader ExecuteQuery(string sqlQuery)
    {
        dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = sqlQuery;
        reader = dbCommand.ExecuteReader();
        return reader;
    }
    /// <summary>
    /// 查询该表所有数据
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <returns></returns>
    public SqliteDataReader ReadFullTable(string tableName)
    {
        string query = "SELECT * FROM " + tableName;
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态添加表字段到指定表
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="values">字段集合</param>
    /// <returns></returns>
    public SqliteDataReader InsertInto(string tableName, string[] values)
    {
        string query = "INSERT INTO " + tableName + " VALUES (" + values[0];
        for (int i = 1; i < values.Length; ++i)
        {
            query += ", " + values[i];
        }
        query += ")";
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态更新表结构
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="cols">字段集</param>
    /// <param name="colsvalues">对于集合值</param>
    /// <param name="selectkey">要查询的字段</param>
    /// <param name="selectvalue">要查询的字段值</param>
    /// <returns></returns>
    public SqliteDataReader UpdateInto(string tableName, string[] cols,string[] colsvalues, string selectkey, string selectvalue)
    {
        string query = "UPDATE " + tableName + " SET " + cols[0] + " = " + colsvalues[0];
        for (int i = 1; i < colsvalues.Length; ++i)
        {
            query += ", " + cols[i] + " =" + colsvalues[i];
        }
        query += " WHERE " + selectkey + " = " + selectvalue + " ";
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态删除指定表字段数据
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="cols">字段</param>
    /// <param name="colsvalues">字段值</param>
    /// <returns></returns>
    public SqliteDataReader Delete(string tableName, string[] cols, string[] colsvalues)
    {
        string query = "DELETE FROM " + tableName + " WHERE " + cols[0] + " = " + colsvalues[0];
        for (int i = 1; i < colsvalues.Length; ++i)
        {
            query += " or " + cols + " = " + colsvalues[i];
        }
        Debug.Log(query);
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态添加数据到指定表
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="cols">字段</param>
    /// <param name="values">值</param>
    /// <returns></returns>
    public SqliteDataReader InsertIntoSpecific(string tableName, string[] cols,
     string[] values)
    {
        if (cols.Length != values.Length)
        {
            throw new SqliteException("columns.Length != values.Length");
        }
        string query = "INSERT INTO " + tableName + "(" + cols[0];
        for (int i = 1; i < cols.Length; ++i)
        {
            query += ", " + cols[i];
        }
        query += ") VALUES (" + values[0];
        for (int i = 1; i < values.Length; ++i)
        {
            query += ", " + values[i];
        }
        query += ")";
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态删除表
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <returns></returns>
    public SqliteDataReader DeleteContents(string tableName)
    {
        string query = "DELETE FROM " + tableName;
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 动态创建表
    /// </summary>
    /// <param name="name">表名</param>
    /// <param name="col">字段</param>
    /// <param name="colType">类型</param>
    /// <returns></returns>
    public SqliteDataReader CreateTable(string name, string[] col, string[] colType)
    {
        if (col.Length != colType.Length)
        {
            throw new SqliteException("columns.Length != colType.Length");
        }
        string query = "CREATE TABLE " + name + " (" + col[0] + " " + colType[0];
        for (int i = 1; i < col.Length; ++i)
        {
            query += ", " + col[i] + " " + colType[i];
        }
        query += ")";
        Debug.Log(query);
        return ExecuteQuery(query);
    }
    /// <summary>
    /// 根据查询条件 动态查询数据信息
    /// </summary>
    /// <param name="tableName">表</param>
    /// <param name="items">查询数据集合</param>
    /// <param name="col">字段</param>
    /// <param name="operation">操作</param>
    /// <param name="values">值</param>
    /// <returns></returns>
    public SqliteDataReader SelectWhere(string tableName, string[] items, string[] col, string[] operation, string[] values)
    {
        if (col.Length != operation.Length || operation.Length != values.Length)
        {
            throw new SqliteException("col.Length != operation.Length != values.Length");
        }
        string query = "SELECT " + items[0];
        for (int i = 1; i < items.Length; ++i)
        {
            query += ", " + items[i];
        }
        query += " FROM " + tableName + " WHERE " + col[0] + operation[0] + "'" + values[0] + "' ";
        for (int i = 1; i < col.Length; ++i)
        {
            query += " AND " + col[i] + operation[i] + "'" + values[i] + "' ";
        }
        return ExecuteQuery(query);
    }
}