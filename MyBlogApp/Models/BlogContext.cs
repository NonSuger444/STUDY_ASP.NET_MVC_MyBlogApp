using System.Data.Entity;

namespace MyBlogApp.Models
{
    /// <summary>
    /// コンテキストクラス
    /// </summary>
    public class BlogContext : DbContext
    {
        /// <summary>
        /// 記事
        /// </summary>
        public DbSet<Article> Articles { get; set; }
        /// <summary>
        /// コメント
        /// </summary>
        public DbSet<Comment> Comments { get; set; }
        /// <summary>
        /// カテゴリ
        /// </summary>
        public DbSet<Category> Categories { get; set; }
    }
}