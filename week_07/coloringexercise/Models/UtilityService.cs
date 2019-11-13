﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coloringexercise.Models
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public string ValidateEmail(string userEmail)
        {
            string response;
            if (userEmail.Contains("@") && userEmail.Contains("."))
            {
               response="Valid email address.";
            }
            else
            {
                response = "Invalid email address.";
            }
           return response;
        }

        public string CodeCeasar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }

        public string DecodeCeasar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character - number - offset) % 26 + offset);
            }

            return result;
        }
    }
}
