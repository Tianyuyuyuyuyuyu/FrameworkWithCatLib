using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework.Save.Sqlite
{
    public interface ISqlite
    {
        /// <summary>
        /// �������ݵ����ݿ�
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="data"></param>
        void Save(string Key, string data);

        /// <summary>
        /// ������ݿ�������
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetData(string key);

        /// <summary>
        /// ������ݿ�������
        /// </summary>
        /// <param name="key"></param>
        void DeleteData(string key);

        /// <summary>
        /// �����ݿⴴ��
        /// </summary>
        void CreateNewDatabase(bool isInGame);

        /// <summary>
        /// �ͷ���Դ
        /// </summary>
        void Release();
    }
}