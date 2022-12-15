using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    [Table("tbl_Credential")]
    internal class Credential
    {
        public Int64 Id { get; set; }
        public const String SALT = "SysSalt";

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        private String _password;
        public String Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 6 && value.Length <= 12)
                {
                    _password = ComputeSHA256(value, SALT);
                }
                else if (value.Length == 64)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A senha deve conter de 8 a 12 caracteres");
                }
            }
        }
        public Boolean Active = false;
        public Boolean Administrator = false;
        [Required]
        public Developer Developer { get; set; }

        public Credential()
        {
        }

        public Credential(string email, string password, bool active, bool administrator)
        {
            Email = email;
            Password = password;
            Active = active;
            Administrator = administrator;
        }


        #region Hashing
        //public static String ComputeSHA256(String input)
        //{
        //    return ComputeSHA256(input, null);
        //}

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion


        public static Boolean Authenticate(String email, String password)
        {
            Developer developer = DeveloperRepository.AuthenticateDeveloper(email);

            if (developer != null)
            {
                String passworddb = developer.Credencial.Password;

                if (passworddb == ComputeSHA256(password, SALT))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Senha Incorreta!!!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("E-mail Incorreto!!!");
                return false;
            }
        }
    }
}
