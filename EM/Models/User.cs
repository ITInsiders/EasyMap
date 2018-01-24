using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Введите логин")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Логин должен быть от 3 до 30 символов")]
        [RegularExpression(@"[aA-zZ][aA-zZ0-9_-]{2,29}", ErrorMessage = "Некорректно введен логин")]
        [System.Web.Mvc.Remote("CheckLogin", "UserController", ErrorMessage = "Данного логина не существует")]
        [DataType(DataType.Text, ErrorMessage = "Данное поле не верного типа")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Пароль должен быть от 8 до 30 символов")]
        [RegularExpression(@"[aA-zZ0-9]{8,30}", ErrorMessage = "Некорректно введен пароль")]
        [DataType(DataType.Password, ErrorMessage = "Данное поле не верного типа")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Имя должно быть от 3 до 30 символов")]
        [RegularExpression(@"[aA-zZаА-яЯ]{3,30}", ErrorMessage = "Некорректно введено имя")]
        [DataType(DataType.Text, ErrorMessage = "Данное поле не верного типа")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 30 символов")]
        [RegularExpression(@"[aA-zZаА-яЯ]{3,30}", ErrorMessage = "Некорректно введена фамилия")]
        [DataType(DataType.Text, ErrorMessage = "Данное поле не верного типа")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Отчество должно быть от 3 до 30 символов")]
        [RegularExpression(@"[aA-zZаА-яЯ]{3,30}", ErrorMessage = "Некорректно введено отчество")]
        [DataType(DataType.Text, ErrorMessage = "Данное поле не верного типа")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите почту")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Почта должна быть от 8 до 30 символов")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный введен почтовый адрес")]
        [System.Web.Mvc.Remote("CheckEmail", "UserController", ErrorMessage = "Данный почтовый адрес уже используется")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Данное поле не верного типа")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите номер телефона")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Номер должн состоять из 12 цифр с +7")]
        [RegularExpression(@"+7[9]{1}[0-9]{9}", ErrorMessage = "Некорректный номер")]
        [System.Web.Mvc.Remote("CheckPhone", "UserController", ErrorMessage = "Данный номер уже используется")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Данное поле не верного типа")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Введите дату своего рождения")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Данное поле не верного типа")]
        public DateTime DateOfBirth { get; set; }

        public string PhotoPath { get; set; }

        public DateTime LastEntrance { get; set; }

        [ForeignKey("Login")]
        public virtual UserVerify UserVerify { get; set; }

        [ForeignKey("Login")]
        public virtual UserData UserData { get; set; }
    }

    public class UserRegistration : User
    {
        [Required(ErrorMessage = "Повторите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password, ErrorMessage = "Данный тип не верный")]
        public string RePassword { get; set; }
    }
}