namespace Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bdkr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.货品类别", "父类编码", "dbo.货品类别");
            DropIndex("dbo.货品类别", new[] { "父类编码" });
            DropColumn("dbo.货品类别", "父类编码");
        }
        
        public override void Down()
        {
            AddColumn("dbo.货品类别", "父类编码", c => c.String(maxLength: 128));
            CreateIndex("dbo.货品类别", "父类编码");
            AddForeignKey("dbo.货品类别", "父类编码", "dbo.货品类别", "编码");
        }
    }
}
