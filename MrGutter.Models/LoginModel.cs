﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrGutter.Models
{
    public class LoginModel
    {
        public string? MobileOrEmail { get; set; }
        public string? Password { get; set; }
        public string? VerificationCode { get; set; }
        public Boolean IsResendOTP { get; set; }=false;
        public Boolean IsLoginWithOtp { get; set; } = false;
    }
}