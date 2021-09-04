using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlogApp.Models
{
    /// <summary>
    /// 記事を管理するクラス
    /// </summary>
    public class Article
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 記事タイトル
        /// </summary>
        [Required]
        [DisplayName("タイトル")]
        public string Title { get; set; }
        /// <summary>
        /// 記事本文
        /// </summary>
        [Required]
        [DisplayName("本文")]
        public string Body { get; set; }
        /// <summary>
        /// 投稿日時
        /// </summary>
        [DisplayName("投稿日")]
        public DateTime Created { get; set; }
        /// <summary>
        /// 更新日時
        /// </summary>
        [DisplayName("更新日")]
        public DateTime Modified { get; set; }
        /// <summary>
        /// カテゴリ - ナビゲーションプロパティ
        /// </summary>
        public virtual Category Category { get; set; }
        /// <summary>
        /// コメントコレクション - ナビゲーションプロパティ
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }
        /// <summary>
        /// カテゴリ名
        /// </summary>
        [NotMapped]
        [DisplayName("カテゴリ")]
        public string CategoryName { get; set; }
    }
}