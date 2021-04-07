namespace BirNotAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotTablosu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false, maxLength: 100),
                        Icerik = c.String(),
                        SonDegistirilme = c.DateTime(nullable: false),
                        YazarId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notlar", "YazarId", "dbo.AspNetUsers");
            DropIndex("dbo.Notlar", new[] { "YazarId" });
            DropTable("dbo.Notlar");
        }
    }
}
