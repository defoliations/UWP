﻿// lindexi
// 16:34

using System;
using System.Text;

namespace lindexi.uwp.ImageShack.Thirdqiniucs.Model.Util
{
    public static class Base64URLSafe
    {
        public static string Encode(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            byte[] bs = Encoding.UTF8.GetBytes(text);
            string encodedStr = Convert.ToBase64String(bs);
            encodedStr = encodedStr.Replace('+', '-').Replace('/', '_');
            return encodedStr;
        }

        /// <summary>
        ///     string扩展方法，生成base64UrlSafe
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToBase64URLSafe(string str)
        {
            return Encode(str);
        }

        public static string Encode(byte[] bs)
        {
            if ((bs == null) || (bs.Length == 0))
            {
                return "";
            }
            string encodedStr = Convert.ToBase64String(bs);
            encodedStr = encodedStr.Replace('+', '-').Replace('/', '_');
            return encodedStr;
        }
    }
}