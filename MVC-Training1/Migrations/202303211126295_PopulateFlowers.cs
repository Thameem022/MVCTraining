﻿namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFlowers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Flowers");
        }
    }
}
