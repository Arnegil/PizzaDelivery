﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaDelivery.ViewModel.ViewModels.PersonalPages.Client
{
    public class RegistrationVM
    {
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        
        [StringLength(100)]
        public string MiddleName { get; set; }
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }
    }
}
