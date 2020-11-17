﻿using System;
using System.ComponentModel;
using FluentValidation;

namespace AvanadeLogin.Core.Models
{
    public class UserAccountModel : INotifyPropertyChanged
    {
        private UserAccountModelValidator Validator { get; }
        public UserAccountModel()
        {
            Validator = new UserAccountModelValidator();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceStartDate { get; set; }

        public void Validade()
        {
            Validator.ValidateAndThrow(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
