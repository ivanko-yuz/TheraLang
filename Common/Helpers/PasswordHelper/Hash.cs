using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Common.Helpers.PasswordHelper
{
    public static class PasswordHasher
    {
        private static byte Version => 1;
        private static int Pbkdf2IterCount { get; } = 50000;
        private static int Pbkdf2SubkeyLength { get; } = 256 / 8; // 256 bits
        private static int SaltSize { get; } = 128 / 8; // 128 bits
        private static HashAlgorithmName HashAlgorithmName { get; } = HashAlgorithmName.SHA256;

        public static string HashPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            byte[] salt;
            byte[] bytes;
            using (var rfc2898DeriveBytes =
                new Rfc2898DeriveBytes(password, SaltSize, Pbkdf2IterCount, HashAlgorithmName))
            {
                salt = rfc2898DeriveBytes.Salt;
                bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
            }

            var inArray = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
            inArray[0] = Version;
            Buffer.BlockCopy(salt, 0, inArray, 1, SaltSize);
            Buffer.BlockCopy(bytes, 0, inArray, 1 + SaltSize, Pbkdf2SubkeyLength);

            return Convert.ToBase64String(inArray);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (hashedPassword == null)
                return false;

            var numArray = Convert.FromBase64String(hashedPassword);
            if (numArray.Length < 1)
                return false;

            var version = numArray[0];
            if (version > Version)
                return false;

            var salt = new byte[SaltSize];
            Buffer.BlockCopy(numArray, 1, salt, 0, SaltSize);
            var a = new byte[Pbkdf2SubkeyLength];
            Buffer.BlockCopy(numArray, 1 + SaltSize, a, 0, Pbkdf2SubkeyLength);
            byte[] bytes;
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, Pbkdf2IterCount, HashAlgorithmName))
            {
                bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
            }

            if (FixedTimeEquals(a, bytes))
                return true;

            return false;
        }


        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static bool FixedTimeEquals(byte[] left, byte[] right)
        {
            if (left.Length != right.Length)
            {
                return false;
            }

            var length = left.Length;
            var accum = 0;

            for (var i = 0; i < length; i++)
            {
                accum |= left[i] - right[i];
            }

            return accum == 0;
        }
    }
}