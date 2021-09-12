using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBlogApp.Models
{
    /// <summary>
    /// LoginViewModel
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// ユーザー名
        /// </summary>
        [Required]
        [DisplayName("ユーザー名")]
        public string UserName { get; set; }
        /// <summary>
        /// パスワード
        /// </summary>
        [Required]
        [DisplayName("パスワード")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}