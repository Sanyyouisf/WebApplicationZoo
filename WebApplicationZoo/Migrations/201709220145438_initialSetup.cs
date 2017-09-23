namespace WebApplicationZoo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalName = c.String(),
                        Class = c.Int(nullable: false),
                        Species = c.Int(nullable: false),
                        Dangerous = c.Boolean(nullable: false),
                        EnclosureId_Id = c.Int(),
                        ZooKeeperId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Environments", t => t.EnclosureId_Id)
                .ForeignKey("dbo.ZooKeepers", t => t.ZooKeeperId_Id)
                .Index(t => t.EnclosureId_Id)
                .Index(t => t.ZooKeeperId_Id);
            
            CreateTable(
                "dbo.Environments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnclosureName = c.String(),
                        Type = c.Int(nullable: false),
                        outdoor = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZooKeepers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZooKeeperName = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        Certified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "ZooKeeperId_Id", "dbo.ZooKeepers");
            DropForeignKey("dbo.Animals", "EnclosureId_Id", "dbo.Environments");
            DropIndex("dbo.Animals", new[] { "ZooKeeperId_Id" });
            DropIndex("dbo.Animals", new[] { "EnclosureId_Id" });
            DropTable("dbo.ZooKeepers");
            DropTable("dbo.Environments");
            DropTable("dbo.Animals");
        }
    }
}
