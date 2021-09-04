using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlogApp.Models
{
    /// <summary>
    /// カテゴリーを管理するクラス
    /// </summary>
    public class Category
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// カテゴリー名 - 一意
        /// </summary>
        [Required]
        [Index(IsUnique=true)]
        [StringLength(255)]
        [DisplayName("カテゴリー")]
        public string CategoryName { get; set; }
        /// <summary>
        /// 記事件数
        /// </summary>
        [DisplayName("件数")]
        public int Count { get; set; }
        /// <summary>
        /// 記事コレクション - ナビゲーションプロパティ
        /// </summary>
        public virtual ICollection<Article> Articles { get; set; }

    }
}