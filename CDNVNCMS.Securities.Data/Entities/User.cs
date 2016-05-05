using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using CDNVNONE.Entities;

namespace CDNVNCMS.Securities.Data
{
    public class User : Entity<int>
    {
        [Required]
        public string Username { get; set; }
        [Required]
        private string PasswordHash { get; set; }
        [Required]
        private string PasswordAlgorithm { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public void SetPassword(string password)
        {
            var arrAlgorithm = new[] { "MD5", "SHA1", "SHA256", "SHA384", "SHA512" };
            if (string.IsNullOrEmpty(PasswordAlgorithm))
            {
                PasswordAlgorithm = arrAlgorithm[new Random().Next(arrAlgorithm.Length)];
            }

            PasswordHash = PasswordHasher.ComputeHash(password, PasswordAlgorithm, null);
        }
        public bool Verify(string password)
        {
            return PasswordHasher.VerifyHash(password, PasswordAlgorithm, PasswordHash);
        }
        public virtual List<UserApplication> AppUserses { get; set; }
        public virtual List<UserMeta> UserMetas { get; set; }
        public class PersonConfiguration : EntityTypeConfiguration<User>
        {
            public PersonConfiguration()
            {
                Property(p => p.PasswordAlgorithm);
                Property(p => p.PasswordHash);
            }
        }

    }

}