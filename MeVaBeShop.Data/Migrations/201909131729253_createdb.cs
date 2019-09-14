namespace MeVaBeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 250),
                        Detail = c.String(storeType: "ntext"),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Content = c.String(storeType: "ntext"),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 12),
                        Email = c.String(maxLength: 50),
                        Address = c.String(maxLength: 250),
                        Content = c.String(maxLength: 250),
                        Status = c.Boolean(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.FeedbackID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        FooterID = c.Int(nullable: false, identity: true),
                        Content = c.String(storeType: "ntext"),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.FooterID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Link = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        Target = c.String(maxLength: 250),
                        Status = c.Boolean(),
                        MenuTypeID = c.Int(),
                        MenuParentID = c.Int(),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.MenuTypes", t => t.MenuTypeID)
                .Index(t => t.MenuTypeID);
            
            CreateTable(
                "dbo.MenuTypes",
                c => new
                    {
                        MenuTypeID = c.Int(nullable: false, identity: true),
                        MenuName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MenuTypeID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 250),
                        CustomerAddress = c.String(nullable: false, maxLength: 250),
                        CustomerEmail = c.String(nullable: false, maxLength: 50),
                        CustomerMobile = c.String(nullable: false, maxLength: 12),
                        CustomerMessage = c.String(maxLength: 500),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        PaymentMethod = c.String(maxLength: 250),
                        PaymentStatus = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false, maxLength: 10),
                        ProductName = c.String(nullable: false, maxLength: 250),
                        MetaTitle = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 500),
                        ProductImage = c.String(maxLength: 250),
                        Image = c.String(storeType: "xml"),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Int(nullable: false),
                        PromotionPrice = c.Int(),
                        IncludeVAT = c.Boolean(),
                        Quantity = c.Int(),
                        CategoryID = c.Int(),
                        Detail = c.String(storeType: "ntext"),
                        Warranty = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        TopHot = c.DateTime(storeType: "date"),
                        ViewCounts = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        SeoTitle = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        ShowOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        TagID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.TagID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        TagName = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        TagID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagID, t.PostID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.TagID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        MetaTitle = c.String(nullable: false, maxLength: 250),
                        Descripton = c.String(maxLength: 250),
                        PostImage = c.String(maxLength: 250),
                        PostCategoryID = c.Int(),
                        Detail = c.String(storeType: "ntext"),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        TopHot = c.DateTime(),
                        ViewCount = c.Int(),
                        TagID = c.Int(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.PostCategories", t => t.PostCategoryID)
                .Index(t => t.PostCategoryID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        PostCategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        MetaTitle = c.String(nullable: false, maxLength: 250),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        SeoTitle = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        ShowOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.PostCategoryID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Content = c.String(),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PageID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SlideID = c.Int(nullable: false, identity: true),
                        Image = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        Link = c.String(maxLength: 250),
                        Description = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.SlideID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        SupportOnlineID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Department = c.String(maxLength: 250),
                        Skype = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Facebook = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SupportOnlineID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ConfigID = c.Int(nullable: false, identity: true),
                        ConfigName = c.String(maxLength: 50),
                        ValueString = c.String(maxLength: 250),
                        ValueInt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConfigID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        VisitorStatisticID = c.Int(nullable: false, identity: true),
                        VistedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.VisitorStatisticID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "MenuTypeID", "dbo.MenuTypes");
            DropIndex("dbo.Posts", new[] { "PostCategoryID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "MenuTypeID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Sliders");
            DropTable("dbo.Pages");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Posts");
            DropTable("dbo.PostTags");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductTags");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.MenuTypes");
            DropTable("dbo.Menus");
            DropTable("dbo.Footers");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Contacts");
            DropTable("dbo.Abouts");
        }
    }
}
