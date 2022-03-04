using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework.Save.Sqlite
{
    public interface ISqlite
    {
        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="data"></param>
        void Save(string Key, string data);

        /// <summary>
        /// 获得数据库内数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetData(string key);

        /// <summary>
        /// 清除数据库内数据
        /// </summary>
        /// <param name="key"></param>
        void DeleteData(string key);

        /// <summary>
        /// 新数据库创建
        /// </summary>
        void CreateNewDatabase(bool isInGame);

        /// <summary>
        /// 释放资源
        /// </summary>
        void Release();
    }
}