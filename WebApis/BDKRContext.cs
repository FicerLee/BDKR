using WebApis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

public class BDKRContext : DbContext
{
    #region DBSet
    public DbSet<采购进货单> 采购进货单S { get; set; }
    public DbSet<采购进货单明细> 采购进货单明细S { get; set; }
    public DbSet<菜品销售单> 菜品销售单S { get; set; }
    public DbSet<菜品销售单明细> 菜品销售单明细S { get; set; }
    public DbSet<仓库类别> 仓库类别S { get; set; }
    public DbSet<仓库信息> 仓库信息S { get; set; }
    public DbSet<供应商信息> 供应商信息S { get; set; }
    public DbSet<货品BOM> 货品BOMS { get; set; }
    public DbSet<货品BOM明细> 货品BOM明细S { get; set; }
    public DbSet<货品类别> 货品类别S { get; set; }
    public DbSet<货品信息> 货品信息S { get; set; }
    public DbSet<计量单位> 计量单位S { get; set; }
    public DbSet<门店信息> 门店信息S { get; set; }
    public DbSet<实时库存明细> 实时库存明细S { get; set; }
    public DbSet<用户信息> 用户信息S { get; set; }

    public DbSet<货品价格> 货品价格S { get; set; }
    public DbSet<销售价格表> 销售价格表S { get; set; }
    public DbSet<餐厅损益表> 餐厅损益表S { get; set; }
    public DbSet<餐厅损益表明细> 餐厅损益表明细S { get; set; }

    public DbSet<日常费用表> 日常费用表S { get; set; }
    public DbSet<日常费用明细表> 日常费用明细表S { get; set; }

    public DbSet<收支费用流水清单> 收支费用流水清单S { get; set; }
    public DbSet<收支费用流水明细清单> 收支费用流水明细清单S { get; set; }
    public DbSet<流水科目> 流水科目S { get; set; }
    public DbSet<流水类别> 流水类别S { get; set; }
    public DbSet<员工信息> 员工信息S { get; set; }
    public DbSet<工资表> 工资表S { get; set; }

    #endregion

    public BDKRContext() : base("BDKRConnection")
    {

    }
    protected override void OnModelCreating(DbModelBuilder mb)
    {
        base.OnModelCreating(mb);
        #region 采购进货单
        mb.Entity<采购进货单>()
            .HasMany(t => t.采购进货单明细List)
            .WithRequired(t => t.采购进货单)
            .HasForeignKey(t => t.采购进货单号)
            .WillCascadeOnDelete(false);
        #endregion

        #region 采购进货单明细
        mb.Entity<采购进货单明细>()
            .Property(t => t.采购金额)
            .HasPrecision(18, 2);
        #endregion

        #region 菜品销售单
        mb.Entity<菜品销售单>()
            .HasMany(t => t.菜品销售单明细List)
            .WithRequired(t => t.菜品销售单)
            .HasForeignKey(t => t.菜品销售单编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 菜品销售单明细
        mb.Entity<菜品销售单明细>()
            .Property(t => t.销售单价)
            .HasPrecision(18, 2);
        mb.Entity<菜品销售单明细>()
            .Property(t => t.实际销售金额)
            .HasPrecision(18, 2);
        #endregion

        #region 仓库类别
        mb.Entity<仓库类别>()
            .HasMany(t => t.仓库信息List)
            .WithRequired(t => t.仓库类别)
            .HasForeignKey(t => t.仓库类别编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 仓库信息
        mb.Entity<仓库信息>()
            .HasMany(t => t.采购进货单明细List)
            .WithRequired(t => t.仓库信息)
            .HasForeignKey(t => t.仓库信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<仓库信息>()
            .HasMany(t => t.实时库存明细List)
            .WithRequired(t => t.仓库信息)
            .HasForeignKey(t => t.仓库信息编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 供应商信息

        #endregion

        #region 货品BOM
        mb.Entity<货品BOM>()
            .HasMany(t => t.货品BOM明细List)
            .WithRequired(t => t.货品BOM)
            .HasForeignKey(t => t.货品BOM编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 货品BOM明细

        #endregion

        #region 货品类别
        mb.Entity<货品类别>()
            .HasMany(t => t.货品信息List)
            .WithRequired(t => t.货品类别)
            .HasForeignKey(t => t.货品类别编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品类别>()
            .HasMany(t => t.Children)
            .WithOptional(t => t.Parent)
            .HasForeignKey(t => t.父类编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 货品信息
        mb.Entity<货品信息>()
            .HasMany(t => t.货品BOMList)
            .WithRequired(t => t.货品信息)
            .HasForeignKey(t => t.货品信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品信息>()
            .HasMany(t => t.货品BOM明细List)
            .WithRequired(t => t.货品信息)
            .HasForeignKey(t => t.货品信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品信息>()
            .HasMany(t => t.采购进货单明细List)
            .WithRequired(t => t.货品信息)
            .HasForeignKey(t => t.货品信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品信息>()
            .HasMany(t => t.实时库存List)
            .WithRequired(t => t.货品信息)
            .HasForeignKey(t => t.货品信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品信息>()
            .HasMany(t => t.菜品销售单明细List)
            .WithRequired(t => t.货品信息)
            .HasForeignKey(t => t.货品信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品信息>()
            .HasOptional(t => t.货品价格)
            .WithRequired(t => t.货品信息)
            .Map(t => t.MapKey("货品编码"))
            .WillCascadeOnDelete(false);
        #endregion

        #region 计量单位

        #endregion

        #region 门店信息
        mb.Entity<门店信息>()
            .HasMany(t => t.仓库信息List)
            .WithRequired(t => t.门店信息)
            .HasForeignKey(t => t.门店信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<门店信息>()
            .HasMany(t => t.采购进货单List)
            .WithRequired(t => t.门店信息)
            .HasForeignKey(t => t.门店信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<门店信息>()
            .HasMany(t => t.菜品销售单List)
            .WithRequired(t => t.门店信息)
            .HasForeignKey(t => t.门店信息编码)
            .WillCascadeOnDelete(false);
        mb.Entity<门店信息>()
            .HasMany(t => t.餐厅损益表List)
            .WithRequired(t => t.门店信息)
            .HasForeignKey(t => t.门店编码)
            .WillCascadeOnDelete(false);
        mb.Entity<门店信息>()
            .HasMany(t => t.员工信息List)
            .WithRequired(t => t.门店信息)
            .HasForeignKey(t => t.门店编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 实时库存信息

        #endregion

        #region 用户信息
        mb.Entity<用户信息>()
            .HasMany(t => t.菜品销售单List)
            .WithRequired(t => t.制单人)
            .HasForeignKey(t => t.制单人编码)
            .WillCascadeOnDelete(false);
        mb.Entity<用户信息>()
            .HasMany(t => t.采购进货单List)
            .WithRequired(t => t.制单人)
            .HasForeignKey(t => t.制单人编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 货品价格
        mb.Entity<货品价格>()
            .HasMany(t => t.采购价格表List)
            .WithRequired(t => t.货品价格)
            .HasForeignKey(t => t.货品价格编码)
            .WillCascadeOnDelete(false);
        mb.Entity<货品价格>()
            .HasMany(t => t.销售价格表List)
            .WithRequired(t => t.货品价格)
            .HasForeignKey(t => t.货品价格编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 采购价格表
        mb.Entity<采购成本价格表>()
            .Property(t => t.价格)
            .HasPrecision(18, 4);

        #endregion

        #region 销售价格表
        mb.Entity<销售价格表>()
           .Property(t => t.价格)
           .HasPrecision(18, 4);
        #endregion

        #region 餐厅损益表
        mb.Entity<餐厅损益表>()
            .HasMany(t => t.餐厅损益表明细List)
            .WithRequired(t => t.餐厅损益表)
            .HasForeignKey(t => t.餐厅损益表编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 餐厅损益表明细
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.人事费用)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.促销费用)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.其他业务支出)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.其他业务收入)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.其他摊提)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.广告费用)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.营业税金)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.营运费用)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.行政费用)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.销售净额)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.销售成本)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.销售收入)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.销售毛利)
            .HasPrecision(18, 4);
        mb.Entity<餐厅损益表明细>()
            .Property(t => t.餐厅资金)
            .HasPrecision(18, 4);
        #endregion

        #region 日常费用表
        mb.Entity<日常费用表>()
            .HasMany(t => t.日常费用明细List)
            .WithRequired(t => t.日常费用表)
            .HasForeignKey(t => t.日常费用表编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 日常费用表明细
        mb.Entity<日常费用明细表>()
            .Property(t => t.书报杂志)
            .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.交通费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.交际应酬费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.低值易耗品摊销)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.促销费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.保险费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.修理费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.其他费用)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.其他费用1)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.其他资产摊销)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.养路费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.劳务费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.劳动保护费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.工会经费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.差旅费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.市场调查费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.广告费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.折旧费用)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.文具印刷费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.无形资产摊销)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.样品费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.水电费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.燃料费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.物料损耗)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.环境保护费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.研究发展费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.职工培训费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.职工福利费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.薪资)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.试验检验费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.运输费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.邮电费)
           .HasPrecision(18, 4);
        mb.Entity<日常费用明细表>()
           .Property(t => t.餐厅租金)
           .HasPrecision(18, 4);
        #endregion

        #region 收支费用流水清单
        mb.Entity<收支费用流水清单>()
            .HasMany(t => t.收支费用流水明细清单List)
            .WithRequired(t => t.收支费用流水清单)
            .HasForeignKey(t => t.收支费用流水清单编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 流水科目
        mb.Entity<流水科目>()
            .HasMany(t => t.收支费用流水明细清单List)
            .WithRequired(t => t.科目)
            .HasForeignKey(t => t.流水科目编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 流水类别
        mb.Entity<流水类别>()
            .HasMany(t => t.收支费用流水明细清单List)
            .WithRequired(t => t.类别)
            .HasForeignKey(t => t.流水类别编码)
            .WillCascadeOnDelete(false);
        #endregion

        #region 收支费用流水明细清单
        mb.Entity<收支费用流水明细清单>()
            .Property(t => t.收支金额)
            .HasPrecision(18, 4);
        #endregion

        #region 工资表
        mb.Entity<工资表>()
            .Property(t => t.基本工资)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.出勤天数)
            .HasPrecision(18, 1);
        mb.Entity<工资表>()
            .Property(t => t.其他)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.奖励)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.工装扣款)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.工装返款)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.满勤奖)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.绩效工资)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.补贴)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.迟到早退)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.酒水)
            .HasPrecision(18, 4);
        mb.Entity<工资表>()
            .Property(t => t.预支工资)
            .HasPrecision(18, 4);
        #endregion

    }
}
