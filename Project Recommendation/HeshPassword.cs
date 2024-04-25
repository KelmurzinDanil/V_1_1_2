﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DB_993
{
    public class HeshPassword
    {
        string Password { get; set; }
        public HeshPassword() { }
        public HeshPassword(string password) 
        {
            Password = password;
        }
        static byte[] GenerateSalt()
        {
            const int SaltLength = 64;
            byte[] salt = new byte[SaltLength];

            var rngRand = new RNGCryptoServiceProvider();
            rngRand.GetBytes(salt);

            return salt;
        }
        static byte[] GenerateSha256Hash(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];

            using var hash = new SHA256CryptoServiceProvider();

            return hash.ComputeHash(saltedPassword);
        }
        public string GetPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] md5Hash = GenerateSha256Hash(password, salt);
            return Convert.ToBase64String(md5Hash);
        }
    }
}
