using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlogApp.Models
{
    /// <summary>
    /// コメントを管理するクラス
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// コメント本文
        /// </summary>
        [Required]
        [DisplayName("コメント")]
        public string Body { get; set; }
        /// <summary>
        /// コメント投稿日時
        /// </summary>
        [DisplayName("投稿日")]
        public DateTime Created { get; set; }
        /// <summary>
        /// 記事 - ナビゲーションプロパティ
        /// </summary>
        public virtual Article Article { get; set; }
        /// <summary>
        /// 記事ID
        /// </summary>
        [NotMapped]
        public int ArticleId { get; set; }
    }
}