using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    internal class CredentialRepository
    {
        public static Developer AuthenticateDataBase(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credential").Where(d => d.Credential.Email == email).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Developer Authenticate(String email, String password)
        {
            Developer developer = AuthenticateDataBase(email);

            if (developer != null)
            {
                String passworddb = developer.Credential.Password;

                if (passworddb == Credential.ComputeSHA256(password, Credential.SALT))
                {
                    return developer;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
