using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Account : IAccount
    {
        public int AccountId { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public float Banlance { get; private set; }
        public void PlayInto(float Amount)
        {
            Banlance += Amount;
        }

        public string ShowInfo()
        {
            return $"Account ID: {AccountId}\tFrist Name: {Fristname}\tLasrt Name: {Lastname}\tGender: {Gender}\tBanlance: {Banlance}";
        }
    }
}
