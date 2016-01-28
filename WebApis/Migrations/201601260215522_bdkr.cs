namespace Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bdkr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.采购进货单",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        制单人编码 = c.String(nullable: false, maxLength: 128),
                        制单日期 = c.DateTime(nullable: false),
                        采购日期 = c.DateTime(nullable: false),
                        供应商编码 = c.String(maxLength: 128),
                        门店信息编码 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.门店信息", t => t.门店信息编码)
                .ForeignKey("dbo.用户信息", t => t.制单人编码)
                .ForeignKey("dbo.供应商信息", t => t.供应商编码)
                .Index(t => t.制单人编码)
                .Index(t => t.供应商编码)
                .Index(t => t.门店信息编码);
            
            CreateTable(
                "dbo.采购进货单明细",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        采购进货单号 = c.String(nullable: false, maxLength: 128),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        单位 = c.String(),
                        数量 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        采购金额 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        仓库信息编码 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.仓库信息", t => t.仓库信息编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .ForeignKey("dbo.采购进货单", t => t.采购进货单号)
                .Index(t => t.采购进货单号)
                .Index(t => t.货品信息编码)
                .Index(t => t.仓库信息编码);
            
            CreateTable(
                "dbo.仓库信息",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        仓库名称 = c.String(nullable: false),
                        门店信息编码 = c.String(nullable: false, maxLength: 128),
                        仓库类别编码 = c.String(nullable: false, maxLength: 128),
                        附件说明 = c.String(),
                        制品缓冲库 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.仓库类别", t => t.仓库类别编码)
                .ForeignKey("dbo.门店信息", t => t.门店信息编码)
                .Index(t => t.门店信息编码)
                .Index(t => t.仓库类别编码);
            
            CreateTable(
                "dbo.仓库类别",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        名称 = c.String(nullable: false),
                        附加说明 = c.String(),
                    })
                .PrimaryKey(t => t.编码);
            
            CreateTable(
                "dbo.门店信息",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        名称 = c.String(),
                        地址 = c.String(),
                        联系电话 = c.String(),
                        备注 = c.String(),
                        店长 = c.String(),
                    })
                .PrimaryKey(t => t.编码);
            
            CreateTable(
                "dbo.菜品销售单",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        制单日期 = c.DateTime(nullable: false),
                        销售日期 = c.DateTime(nullable: false),
                        制单人编码 = c.String(nullable: false, maxLength: 128),
                        门店信息编码 = c.String(nullable: false, maxLength: 128),
                        备注 = c.String(),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.用户信息", t => t.制单人编码)
                .ForeignKey("dbo.门店信息", t => t.门店信息编码)
                .Index(t => t.制单人编码)
                .Index(t => t.门店信息编码);
            
            CreateTable(
                "dbo.菜品销售单明细",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        菜品销售单编码 = c.String(nullable: false, maxLength: 128),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        数量 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        销售单价 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        实际销售金额 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .ForeignKey("dbo.菜品销售单", t => t.菜品销售单编码)
                .Index(t => t.菜品销售单编码)
                .Index(t => t.货品信息编码);
            
            CreateTable(
                "dbo.货品信息",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        名称 = c.String(),
                        货品类别编码 = c.String(nullable: false, maxLength: 128),
                        拼音 = c.String(),
                        备注 = c.String(),
                        单位 = c.String(),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品类别", t => t.货品类别编码)
                .Index(t => t.货品类别编码);
            
            CreateTable(
                "dbo.货品BOM",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        更新时间 = c.DateTime(nullable: false),
                        过期时间 = c.DateTime(),
                        备注 = c.String(),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .Index(t => t.货品信息编码);
            
            CreateTable(
                "dbo.货品BOM明细",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        单份数量 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        单位 = c.String(),
                        货品BOM编码 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品BOM", t => t.货品BOM编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .Index(t => t.货品信息编码)
                .Index(t => t.货品BOM编码);
            
            CreateTable(
                "dbo.货品单位换算",
                c => new
                    {
                        编码 = c.Int(nullable: false, identity: true),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        计量单位1 = c.String(),
                        计量单位2 = c.String(),
                        换算比率 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .Index(t => t.货品信息编码);
            
            CreateTable(
                "dbo.货品类别",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        名称 = c.String(),
                        父类编码 = c.String(maxLength: 128),
                        备注 = c.String(),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品类别", t => t.父类编码)
                .Index(t => t.父类编码);
            
            CreateTable(
                "dbo.实时库存明细",
                c => new
                    {
                        编码 = c.Int(nullable: false, identity: true),
                        仓库信息编码 = c.String(nullable: false, maxLength: 128),
                        货品信息编码 = c.String(nullable: false, maxLength: 128),
                        数量 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        门店信息_编码 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.编码)
                .ForeignKey("dbo.货品信息", t => t.货品信息编码)
                .ForeignKey("dbo.门店信息", t => t.门店信息_编码)
                .ForeignKey("dbo.仓库信息", t => t.仓库信息编码)
                .Index(t => t.仓库信息编码)
                .Index(t => t.货品信息编码)
                .Index(t => t.门店信息_编码);
            
            CreateTable(
                "dbo.用户信息",
                c => new
                    {
                        账号 = c.String(nullable: false, maxLength: 128),
                        姓名 = c.String(nullable: false),
                        密码 = c.String(nullable: false),
                        备注说明 = c.String(),
                    })
                .PrimaryKey(t => t.账号);
            
            CreateTable(
                "dbo.供应商信息",
                c => new
                    {
                        编码 = c.String(nullable: false, maxLength: 128),
                        名称 = c.String(nullable: false),
                        联系电话 = c.String(),
                        地址 = c.String(),
                        备注 = c.String(),
                    })
                .PrimaryKey(t => t.编码);
            
            CreateTable(
                "dbo.计量单位",
                c => new
                    {
                        名称 = c.String(nullable: false, maxLength: 128),
                        快速访问 = c.String(),
                    })
                .PrimaryKey(t => t.名称);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.采购进货单", "供应商编码", "dbo.供应商信息");
            DropForeignKey("dbo.采购进货单明细", "采购进货单号", "dbo.采购进货单");
            DropForeignKey("dbo.实时库存明细", "仓库信息编码", "dbo.仓库信息");
            DropForeignKey("dbo.实时库存明细", "门店信息_编码", "dbo.门店信息");
            DropForeignKey("dbo.仓库信息", "门店信息编码", "dbo.门店信息");
            DropForeignKey("dbo.菜品销售单", "门店信息编码", "dbo.门店信息");
            DropForeignKey("dbo.菜品销售单", "制单人编码", "dbo.用户信息");
            DropForeignKey("dbo.采购进货单", "制单人编码", "dbo.用户信息");
            DropForeignKey("dbo.菜品销售单明细", "菜品销售单编码", "dbo.菜品销售单");
            DropForeignKey("dbo.实时库存明细", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.货品信息", "货品类别编码", "dbo.货品类别");
            DropForeignKey("dbo.货品类别", "父类编码", "dbo.货品类别");
            DropForeignKey("dbo.货品单位换算", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.货品BOM明细", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.货品BOM", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.货品BOM明细", "货品BOM编码", "dbo.货品BOM");
            DropForeignKey("dbo.菜品销售单明细", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.采购进货单明细", "货品信息编码", "dbo.货品信息");
            DropForeignKey("dbo.采购进货单", "门店信息编码", "dbo.门店信息");
            DropForeignKey("dbo.仓库信息", "仓库类别编码", "dbo.仓库类别");
            DropForeignKey("dbo.采购进货单明细", "仓库信息编码", "dbo.仓库信息");
            DropIndex("dbo.实时库存明细", new[] { "门店信息_编码" });
            DropIndex("dbo.实时库存明细", new[] { "货品信息编码" });
            DropIndex("dbo.实时库存明细", new[] { "仓库信息编码" });
            DropIndex("dbo.货品类别", new[] { "父类编码" });
            DropIndex("dbo.货品单位换算", new[] { "货品信息编码" });
            DropIndex("dbo.货品BOM明细", new[] { "货品BOM编码" });
            DropIndex("dbo.货品BOM明细", new[] { "货品信息编码" });
            DropIndex("dbo.货品BOM", new[] { "货品信息编码" });
            DropIndex("dbo.货品信息", new[] { "货品类别编码" });
            DropIndex("dbo.菜品销售单明细", new[] { "货品信息编码" });
            DropIndex("dbo.菜品销售单明细", new[] { "菜品销售单编码" });
            DropIndex("dbo.菜品销售单", new[] { "门店信息编码" });
            DropIndex("dbo.菜品销售单", new[] { "制单人编码" });
            DropIndex("dbo.仓库信息", new[] { "仓库类别编码" });
            DropIndex("dbo.仓库信息", new[] { "门店信息编码" });
            DropIndex("dbo.采购进货单明细", new[] { "仓库信息编码" });
            DropIndex("dbo.采购进货单明细", new[] { "货品信息编码" });
            DropIndex("dbo.采购进货单明细", new[] { "采购进货单号" });
            DropIndex("dbo.采购进货单", new[] { "门店信息编码" });
            DropIndex("dbo.采购进货单", new[] { "供应商编码" });
            DropIndex("dbo.采购进货单", new[] { "制单人编码" });
            DropTable("dbo.计量单位");
            DropTable("dbo.供应商信息");
            DropTable("dbo.用户信息");
            DropTable("dbo.实时库存明细");
            DropTable("dbo.货品类别");
            DropTable("dbo.货品单位换算");
            DropTable("dbo.货品BOM明细");
            DropTable("dbo.货品BOM");
            DropTable("dbo.货品信息");
            DropTable("dbo.菜品销售单明细");
            DropTable("dbo.菜品销售单");
            DropTable("dbo.门店信息");
            DropTable("dbo.仓库类别");
            DropTable("dbo.仓库信息");
            DropTable("dbo.采购进货单明细");
            DropTable("dbo.采购进货单");
        }
    }
}
