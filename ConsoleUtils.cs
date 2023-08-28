using LitJson;
using System;
using TinyJson;
using UnityEngine;

namespace Game
{
    public class ConsoleUtils
    {
        /// <summary>
        /// 打印到控制台
        /// </summary>
        /// <param name="objs"></param>
        public static void Log(params object[] objs)
        {
            string str = string.Empty;
            bool isWrap = false;
            foreach (object obj in objs)
            {
                Type type = obj.GetType();
                string extra = string.Empty;
                if (type.Name.IndexOf("[]") != -1)
                {
                    extra = ",\r\n[ ";
                    Array objArray = (Array)obj;
                    int i = 0;
                    int len = objArray.Length;
                    foreach (object data in objArray)
                    {
                        extra += data.ToString() + (i == len - 1 ? string.Empty : " , ");
                        i++;
                    }

                    extra += " ]";
                    str += extra;
                    isWrap = true;
                }
                else if (type == typeof(JsonData))
                {
                    string json = ((JsonData)obj).ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else if (type.Name.IndexOf("Dictionary") != -1)
                {
                    string json = obj.ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else
                {
                    if (isWrap)
                    {
                        isWrap = false;
                        str += ",\r\n";
                    }
                    str += obj.ToString() + " ";
                }
            }
            Debug.Log(str);
        }

        public static void Warn(params object[] objs)
        {
            string str = string.Empty;
            bool isWrap = false;
            foreach (object obj in objs)
            {
                Type type = obj.GetType();
                string extra = string.Empty;
                if (type.Name.IndexOf("[]") != -1)
                {
                    extra = ",\r\n[ ";
                    Array objArray = (Array)obj;
                    int i = 0;
                    int len = objArray.Length;
                    foreach (object data in objArray)
                    {
                        extra += data.ToString() + (i == len - 1 ? string.Empty : " , ");
                        i++;
                    }

                    extra += " ]";
                    str += extra;
                    isWrap = true;
                }
                else if (type == typeof(JsonData))
                {
                    string json = ((JsonData)obj).ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else if (type.Name.IndexOf("Dictionary") != -1)
                {
                    string json = obj.ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else
                {
                    if (isWrap)
                    {
                        isWrap = false;
                        str += "\r\n";
                    }
                    str += obj.ToString() + " ";
                }
            }
            Debug.LogWarning(str);
        }

        public static void Error(params object[] objs)
        {
            string str = string.Empty;
            bool isWrap = false;
            foreach (object obj in objs)
            {
                Type type = obj.GetType();
                string extra = string.Empty;
                if (type.Name.IndexOf("[]") != -1)
                {
                    extra = ",\r\n[ ";
                    Array objArray = (Array)obj;
                    int i = 0;
                    int len = objArray.Length;
                    foreach (object data in objArray)
                    {
                        extra += data.ToString() + (i == len - 1 ? string.Empty : " , ");
                        i++;
                    }

                    extra += " ]";
                    str += extra;
                    isWrap = true;
                }
                else if (type == typeof(JsonData))
                {
                    string json = ((JsonData)obj).ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else if (type.Name.IndexOf("Dictionary") != -1)
                {
                    string json = obj.ToJson();
                    str += ",\r\n" + json;
                    isWrap = true;
                }
                else
                {
                    if (isWrap)
                    {
                        isWrap = false;
                        str += "\r\n";
                    }
                    str += obj.ToString() + " ";
                }
            }
            Debug.LogError(str);
        }
    }
}