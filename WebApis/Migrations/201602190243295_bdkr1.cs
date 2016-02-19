namespace Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bdkr1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.采购成本价格表", "货品价格编码", "dbo.货品价格");
            DropForeignKey("dbo.销售价格表", "货品价格编码", "dbo.货品价格");
            DropForeignKey("dbo.货品价格", "货品编码", "dbo.货品信息");
            DropIndex("dbo.货品价格", new[] { "货品编码" });
            DropIndex("dbo.采购成本价格表", new[] { "货品价格编码" });
            DropIndex("dbo.销售价格表", new[] { "货品价格编码" });
            AddColumn("dbo.采购成本价格表", "货品信息编码", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.销售价格表", "货品信息编码", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.采购成本价格表", "货品信息编码");
            CreateIndex("dbo.销售价格表", "货品信息编码");
            AddForeignKey("dbo.采购成本价格表", "货品信息编码", "dbo.货品信息", "编码");
            AddForeignKey("dbo.销售价格表", "货品信息编码", "dbo.货品信息", "编码");
            DropColumn("dbo.货品信息", "货品价格编码");
            DropColumn("dbo.采购成本价格表", "货品价格编码");
            DropColumn("dbo.销售价格表", "货品价格编码");
            DropTable("dbo.货品价格");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.货品价格",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        附加说明 = c.String(),
                        货品编码 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.编码);
            
            AddColumn("dbo.销售价格表", "货品价格编码", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.采购成本价格表", "货品价格编码", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.货品信息", "货品价格编码", c => c.String());
            DropForeignKey("dbo.销售价格表", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.采购成本价格表", "货品信息编码", "dbo.货品信息");
            DropIndex("dbo.销售价格表", new[] { "货品信息编码" });
            DropIndex("dbo.采购成本价格表", new[] { "货品信息编码" });
            DropColumn("dbo.销售价格表", "货品信息编码");
            DropColumn("dbo.采购成本价格表", "货品信息编码");
            CreateIndex("dbo.销售价格表", "货品价格编码");
            CreateIndex("dbo.采购成本价格表", "货品价格编码");
            CreateIndex("dbo.货品价格", "货品编码");
            AddForeignKey("dbo.货品价格", "货品编码", "dbo.货品信息", "编码");
            AddForeignKey("dbo.销售价格表", "货品价格编码", "dbo.货品价格", "编码");
            AddForeignKey("dbo.采购成本价格表", "货品价格编码", "dbo.货品价格", "编码");
        }
    }
}
