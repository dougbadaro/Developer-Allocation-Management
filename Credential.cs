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
    public class Credential
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
                    MessageBox.Show("Password must contain 6 to 12 characters.");
                }
            }
        }
        public Boolean Active { get; set; }
        public Boolean Administrator { get; set; }
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

        public override string ToString()
        {
            return $"{Email}";
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
    }
}
