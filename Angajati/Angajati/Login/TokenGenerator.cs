using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajati.Login
{
    public class TokenGenerator
    {
        private string _token;
        private DateTime _creationTime;

        public string GenerateToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; 
            Random random = new Random(); 

            _token = new string(Enumerable.Repeat(chars, 6)
                                          .Select(s => s[random.Next(s.Length)]).ToArray());

            _creationTime = DateTime.Now; 
            return _token; 
        }


        public bool IsTokenValid()
        {
            TimeSpan timeElapsed = DateTime.Now - _creationTime;
            return timeElapsed.TotalMinutes <= 5;
        }


        public string GetToken()
        {
            return _token;
        }
    }
}
